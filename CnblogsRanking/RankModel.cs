using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnblogsRanking
{
    public class RankModel
    {
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        [LiteDB.BsonId]
        /// <summary>
        /// 主页
        /// </summary>
        public string Url { get; set; }
        public string Value { get; set; }
        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastDateTime { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public string Score { get; set; }
        public override string ToString()
        {
            return $"{this.Id}用户名：{this.Name},积分:{this.Score},更新时间:{this.LastDateTime.ToLongDateString()}";
        }

    }
}
