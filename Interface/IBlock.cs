using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SkynetScan.Models;

namespace SkynetScan.Interface
{
    public interface IBlock
    {
        IMongoCollection<BlockModel> Blockcollection { get; }
        long CountBlock();
        IEnumerable<BlockModel> GetLimitBlock();
        IEnumerable<BlockModel> GetLimitBlockWithPage(int page);
        BlockModel GetBlock(ulong Blocknumber);

        void CreateBlock(BlockModel block);
        void UpdateBlock(string _id, BlockModel block);
    }
}
