using System;

namespace OnlineAuctionSys
{
    public delegate void AuctionStatusChanged(string message);
    public class AuctionItem
    {
        public string ItemName { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentBid { get; set; }
        public DateTime AuctionEndTime { get; set; }

        public AuctionItem(string itemName, decimal startingPrice, DateTime auctionEndTime)
        {
            ItemName = itemName;
            StartingPrice = startingPrice;
            AuctionEndTime = auctionEndTime;
            CurrentBid = startingPrice;
        }
        public void UpdateBid(decimal bidAmount)
        {
            if (bidAmount > CurrentBid)
            {
                CurrentBid = bidAmount;
                Console.WriteLine($"New bid placed: {CurrentBid}");
            }
            else
            {
                Console.WriteLine("Bid must be higher than the current bid.");
            }
        }
    }
}

