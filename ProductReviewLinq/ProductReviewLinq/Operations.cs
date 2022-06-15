using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewLinq
{
    public class Operations
    {
        public void GetTopThreeRecords(List<ProductReview> reviewlist)
        {
            var result = reviewlist.OrderByDescending(x => x.Rating).Take(3).ToList();
            Display(result);
        }
        public void GetTopRecordsWithProductId(List<ProductReview> list)
        {
            var result = list.Where(x => x.Rating > 3 && (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9)).Take(3).ToList();
            Display(result);
        }

        public void GetTopRecordsCountWithProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach (var data in result)
            {
                Console.WriteLine(data.ProductID + " " + data.Count);
            }
        }
        public void Display(List<ProductReview> list)
        {
            //Display list
            foreach (var product in list)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Product id "+ product.ProductId + " User id " + product.UserId + " Product Rating " + product.Rating + " Product Review " + product.Review + " Product is like " + product.IsLike);
            }
        }
     
    }
}
