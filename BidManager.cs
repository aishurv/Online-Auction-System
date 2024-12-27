using System;

namespace OnlineAuctionSys
{
    public class BidManager
    {
        public event AuctionStatusChanged AuctionStatus;

        public void StartAuction(AuctionItem item)
        {
            Console.WriteLine("Auction started for " + item.ItemName);
        }

        public void EndAuction(AuctionItem item, User winningUser)
        {
            Console.WriteLine($"Auction ended for {item.ItemName}");
            string message = winningUser != null
                ? $"{winningUser.UserName} won the auction for {item.ItemName} with a bid of {item.CurrentBid}."
                : "No winner, auction failed.";

            AuctionStatus.Invoke(message);  // Triggering the event
        }
    }
}
