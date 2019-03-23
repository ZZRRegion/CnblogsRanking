using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;

namespace CnblogsRanking
{
    public class CBRank
    {
        public string Url => "https://www.cnblogs.com/AllBloggers.aspx";
        public string DbLite => "blog.db";
        public HttpClient HttpClient { get; } = new HttpClient();
        public CBRank()
        {
        }
        public async Task<Dictionary<string, RankModel>> Start()
        {
            Dictionary<string, RankModel> dict = new Dictionary<string, RankModel>();
            string result = await this.HttpClient.GetStringAsync(this.Url);
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(result);
            HtmlNode table = html.DocumentNode.SelectSingleNode(".//table[@width='90%']");
            HtmlNodeCollection tds = table.SelectNodes(".//td");
            foreach(HtmlNode td in tds)
            {
                HtmlNode a = td.SelectSingleNode(".//a[not(@class)]");
                if (a == null)
                    continue;
                RankModel rankModel = new RankModel();
                rankModel.Id = System.Web.HttpUtility.HtmlDecode(td.FirstChild.InnerText);
                rankModel.Url = a.GetAttributeValue("href", string.Empty);
                rankModel.Name = a.InnerText;
                string small = td.LastChild.InnerText;
                if (!string.IsNullOrEmpty(small))
                {
                    small = small.Replace("(", "").Replace(")", "").Replace(" ", "");
                    string[] splits = small.Split(',');
                    if(splits.Length == 3)
                    {
                        rankModel.Value = splits[0];
                        rankModel.LastDateTime = DateTime.Parse(splits[1]);
                        rankModel.Score = splits[2];
                    }
                }
                if (!dict.ContainsKey(rankModel.Name))
                {
                    dict.Add(rankModel.Name, rankModel);
                }
                else
                {
                    Console.WriteLine(rankModel.Name);
                }
            }
            return dict;
        }
        public void SaveBlogModel(List<BlogModel> blogModels, string collectionName)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            LiteDB.LiteDatabase liteDatabase = new LiteDB.LiteDatabase(this.DbLite);
            LiteDB.LiteCollection<BlogModel> liteCollection = liteDatabase.GetCollection<BlogModel>(collectionName.RepleaceBrackets());
            int count = 0;
            foreach(BlogModel blogModel in blogModels)
            {
                count++;
                BlogModel model = liteCollection.FindOne(item => item.PostUrl == blogModel.PostUrl);
                if(model == null)
                {
                    LiteDB.BsonValue bsonValue = liteCollection.Insert(blogModel);
                }
                else
                {

                }
            }
            liteDatabase.Dispose();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
        public void SaveRankModel(Dictionary<string, RankModel> dict)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            LiteDB.LiteDatabase liteDatabase = new LiteDB.LiteDatabase(this.DbLite);
            LiteDB.LiteCollection<RankModel> liteCollection = liteDatabase.GetCollection<RankModel>("博客园排行");
            int count = 0;
            foreach(KeyValuePair<string, RankModel> itemRank in dict)
            {
                count++;
                RankModel model = liteCollection.FindOne(item => item.Name == itemRank.Key);
                if(model == null)
                {
                    LiteDB.BsonValue bsonValue = liteCollection.Insert(itemRank.Value);
                }
                else
                {

                }
            }
            liteDatabase.Dispose();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }
        public async Task<List<BlogModel>> LookBlog(string url)
        {
            List<BlogModel> lst = new List<BlogModel>();
            string result = await this.HttpClient.GetStringAsync(url);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(result);
            HtmlNodeCollection days = doc.DocumentNode.SelectNodes(".//div[@class='day']");
            if (days == null)
                return lst;
            foreach(HtmlNode day in days)
            {
                BlogModel blogModel = new BlogModel();
                HtmlNode divPostTitle = day.SelectSingleNode(".//div[@class='postTitle']");
                if (divPostTitle == null)
                    continue;
                blogModel.PostTitle = divPostTitle.InnerText;
                HtmlNode divPostCon = day.SelectSingleNode(".//div[@class='postCon']");
                if (divPostCon == null)
                    continue;
                blogModel.PostCon = divPostCon.InnerText?.Replace("阅读全文", string.Empty);
                blogModel.PostUrl = divPostCon.SelectSingleNode(".//a")?.GetAttributeValue("href", string.Empty);
                HtmlNode divPostDesc = day.SelectSingleNode(".//div[@class='postDesc']");
                if (divPostDesc == null)
                    continue;
                blogModel.Post = divPostDesc.InnerText?.Replace("编辑", string.Empty);
                if (string.IsNullOrEmpty(blogModel.PostUrl))
                    continue;
                lst.Add(blogModel);
            }
            return lst;
        }
        public List<string> GetCollectionNames()
        {
            LiteDB.LiteDatabase liteDatabase = new LiteDB.LiteDatabase(this.DbLite);
            List<string> lst = liteDatabase.GetCollectionNames().ToList();
            liteDatabase.Dispose();
            return lst;
        }
    }
}
