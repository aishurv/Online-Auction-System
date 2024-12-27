using System;

namespace OnlineAuctionSys
{
    public class User
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }

        public User(string userName, string userEmail)
        {
            UserName = userName;
            UserEmail = userEmail;
        }

        public void NotifyUser(string message)
        {
            Console.WriteLine($"{UserName} ({UserEmail}) - Notification: {message}");
        }
        public void PlaceBid(AuctionItem item, decimal bidAmount)
        {
            item.UpdateBid(bidAmount);
        }
    }

}