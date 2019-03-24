using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnblogsRanking
{
    public class BlogModel
    {
        /// <summary>
        /// 标题内容
        /// </summary>
        public string PostTitle { get; set; }
        [LiteDB.BsonId]
        /// <summary>
        /// 访问URL
        /// </summary>
        public string PostUrl { get; set; }
        /// <summary>
        ///摘要
        /// </summary>
        public string PostCon { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime PostDateTime { get; set; }
        /// <summary>
        /// 阅读量
        /// </summary>
        public int Reading { get; set; }
        /// <summary>
        /// 评论量
        /// </summary>
        public int Comment { get; set; }
        public string Post { get; set; }
        public string HtmlContent { get; set; }
    }
}
