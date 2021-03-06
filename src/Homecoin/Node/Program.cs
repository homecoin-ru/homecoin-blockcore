/*
19.03.2021 1.0.20.1 Checkpoints 29000 and
            var bip9Deployments = new HomeCoinBIP9Deployments()
            {
                [HomeCoinBIP9Deployments.CSV] = new BIP9DeploymentsParameters("CSV", 0, BIP9DeploymentsParameters.AlwaysActive, 999999999, BIP9DeploymentsParameters.AlwaysActive),        
                [HomeCoinBIP9Deployments.Segwit] = new BIP9DeploymentsParameters("Segwit", 1, BIP9DeploymentsParameters.AlwaysActive, 999999999, BIP9DeploymentsParameters.AlwaysActive),
                [HomeCoinBIP9Deployments.ColdStaking] = new BIP9DeploymentsParameters("ColdStaking", 2, BIP9DeploymentsParameters.AlwaysActive, 999999999, BIP9DeploymentsParameters.AlwaysActive),

            };
21.03.2021 1.0.20.2 Checkpoints 33333
 * */
using System;
using System.Threading.Tasks;
using Blockcore;
using Blockcore.Builder;
using Blockcore.Configuration;
using Blockcore.Features.BlockStore;
using Blockcore.Features.ColdStaking;
using Blockcore.Features.Consensus;
using Blockcore.Features.Diagnostic;
using Blockcore.Features.MemoryPool;
using Blockcore.Features.Miner;
using Blockcore.Features.NodeHost;
using Blockcore.Features.RPC;
using Blockcore.Utilities;

namespace HomeCoin.Daemon
{
   public class Program
   {
      public static async Task Main(string[] args)
      {
         try
         {
            var nodeSettings = new NodeSettings(networksSelector: Networks.Networks.HomeCoin, args: args);

            IFullNodeBuilder nodeBuilder = new FullNodeBuilder()
                .UseNodeSettings(nodeSettings)
                .UseBlockStore()
                .UsePosConsensus()
                .UseMempool()
                .UseColdStakingWallet()
                .AddPowPosMining()
                .UseNodeHost()
                .AddRPC()
                .UseDiagnosticFeature();

            IFullNode node = nodeBuilder.Build();

            if (node != null)
               await node.RunAsync();
         }
         catch (Exception ex)
         {
            Console.WriteLine("There was a problem initializing the node. Details: '{0}'", ex);
         }
      }
   }
}
