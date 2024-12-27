using System;
namespace OnlineAuctionSys
{
    public class OnlineAuctionSystem
    {
        public static void Main()
        {
            AuctionItem auctionItem = new AuctionItem("Laptop", 500, DateTime.Now.AddMinutes(30));

            User user1 = new User("Aishu", "aishu@auction.com");
            User user2 = new User("Laxmi", "laxmi@auction.com");

            BidManager bidManager = new BidManager();

            bidManager.AuctionStatus += user1.NotifyUser;
            bidManager.AuctionStatus += user2.NotifyUser;

            bidManager.StartAuction(auctionItem);

            user1.PlaceBid(auctionItem, 600);
            user2.PlaceBid(auctionItem, 650);

            bidManager.EndAuction(auctionItem, user2);
        }
    }
}
