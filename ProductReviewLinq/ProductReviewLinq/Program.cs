﻿using System;
using ProductReviewLinq;

namespace ProductReviewLinq;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to product Review Management");
        List<ProductReview> reviewList = new List<ProductReview>();
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
        //Display List
        foreach (var item in reviewList)
        {
            Console.WriteLine("Product Id :" + item.ProductId + " " + " UserId :" + item.UserId + " " + "Rating:" + item.Rating + " " + "Review: " + item.Review + " " + "IsLike :" + item.IsLike);
        }
    }
}