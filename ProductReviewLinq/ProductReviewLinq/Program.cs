using System;
using ProductReviewLinq;

namespace ProductReviewLinq;
class Program
{
    static void Main(String[] args)
    {
        
       
        //UC1
       
                    List<ProductReview> reviewList = new List<ProductReview>();
                    Console.WriteLine("Welcome to product Review Management");
                   
                    reviewList.Add(new ProductReview() { ProductId = 1, UserId = 111, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 2, UserId = 112, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 3, UserId = 113, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 4, UserId = 114, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 5, UserId = 115, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 6, UserId = 116, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 7, UserId = 117, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 8, UserId = 118, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 9, UserId = 119, Rating = 1, Review = "worst", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 10, UserId = 120, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 11, UserId = 121, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 12, UserId = 122, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 13, UserId = 123, Rating = 2, Review = "bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 14, UserId = 124, Rating = 1, Review = "worst", IsLike = false });
            reviewList.Add(new ProductReview() { ProductId = 15, UserId = 125, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 16, UserId = 126, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 17, UserId = 127, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 18, UserId = 128, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 19, UserId = 129, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 20, UserId = 130, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 21, UserId = 131, Rating = 2, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 22, UserId = 132, Rating = 5, Review = "best", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 23, UserId = 133, Rating = 4, Review = "better", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 24, UserId = 134, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductId = 25, UserId = 135, Rating = 2, Review = "bad", IsLike = false });
               

        bool end = true;
        while (end)
        {
            Console.WriteLine("\n1.Create Product Review\n2.Retrive Top Three Records \n3.Retrive Top Record With Product Id \n4.Get Top Record count with product id\n5.Get All Record\n6.Skip top 5 record\n7.Datatble\n8.End Of Program");
            Console.WriteLine("\nEnter above Option");
            int option = Convert.ToInt16(Console.ReadLine());
            Operations operations = new Operations();
            switch (option)
            {
                case 1:
                    operations.Display(reviewList);
                    break;
                case 2:
                    operations.GetTop3Records(reviewList);
                    break;
                case 3:
                    operations.GetTopRecordsWithProductId(reviewList);
                    break;
                case 4:
                    operations.GetTopRecordsCountWithProductId(reviewList);

                    break;
                case 5:
                    operations.GetAllRecords(reviewList);
                    break ;
                    case 6:
                        operations.SkipTop5Records(reviewList);
                    break;
                case 7:
                    operations.Datatables();
                    break;
                case 0:
                    end = false;
                    break;
                default:
                    Console.WriteLine("\n Invalid Option");
                    break;
            }
        }

    }
}
