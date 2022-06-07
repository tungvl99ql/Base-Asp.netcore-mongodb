using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace SkynetScan.Models
{
    public class BlockModel
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string difficulty { get; set; }
        public string extraData { get; set; }
        public string gasLimit { get; set; }
        public string gasUsed { get; set; }
        public string hash { get; set; }
        public string logsBloom { get; set; }
        public string miner { get; set; }
        public string mixHash { get; set; }
        public string nonce { get; set; }
        public ulong number { get; set; }
        public string parentHash { get; set; }
        public string receiptsRoot { get; set; }
        public string sha3Uncles { get; set; }
        public int size { get; set; }
        public string stateRoot { get; set; }
        public int timestamp { get; set; }
        public string totalDifficulty { get; set; }
        public List<string> transactions { get; set; }
        public string transactionsRoot { get; set; }
        public List<string> uncles { get; set; }

        [NotMapped]
        public string hashMinertiny { get; set; }
        [NotMapped]
        public float GasUsedPercent { get; set; }
    }
}
