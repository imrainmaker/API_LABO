using DAL.Enums;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {


        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                            new Product
                            {
                                ProductId = 1,
                                Name = "Ancient Greek Vase",
                                Description = "This vase dates back to the 5th century BCE and features intricate red-figure artwork.",
                                Price = 1000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 2
                            },
                            new Product
                            {
                                ProductId = 2,
                                Name = "Roman Marble Bust",
                                Description = "This bust of a Roman emperor is made of high-quality marble and dates back to the 2nd century CE.",
                                Price = 15000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 4
                            },
                            new Product
                            {
                                ProductId = 3,
                                Name = "Medieval Tapestry",
                                Description = "This tapestry depicts scenes from the life of King Arthur and dates back to the 14th century.",
                                Price = 50000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 6
                            },
                            new Product
                            {
                                ProductId = 4,
                                Name = "Egyptian Papyrus Scroll",
                                Description = "This scroll features hieroglyphics and dates back to the 18th dynasty of ancient Egypt.",
                                Price = 8000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 10
                            },
                            new Product
                            {
                                ProductId = 5,
                                Name = "Renaissance Oil Painting",
                                Description = "This oil painting from the 16th century features a religious scene and is signed by the artist.",
                                Price = 40000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 4
                            },
                            new Product
                            {
                                ProductId = 6,
                                Name = "Aztec Stone Sculpture",
                                Description = "This sculpture from the Aztec civilization is made of stone and depicts a god.",
                                Price = 20000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 2
                            },
                            new Product
                            {
                                ProductId = 7,
                                Name = "Chinese Jade Figurine",
                                Description = "This figurine from ancient China is made of jade and depicts a mythical creature.",
                                Price = 12000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 6
                            },
                            new Product
                            {
                                ProductId = 8,
                                Name = "Byzantine Mosaic",
                                Description = "This mosaic from the Byzantine Empire depicts a religious scene and dates back to the 6th century CE.",
                                Price = 35000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 2
                            },
                            new Product
                            {
                                ProductId = 9,
                                Name = "Mayan Pottery",
                                Description = "This pottery from the Mayan civilization features intricate designs and patterns.",
                                Price = 5000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 7
                            },
                            new Product
                            {
                                ProductId = 10,
                                Name = "Persian Rug",
                                Description = "This rug from Persia is made of high-quality wool and features intricate designs and patterns.",
                                Price = 25000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 10
                            },
                            new Product
                            {
                                ProductId = 11,
                                Name = "Egyptian Papyrus",
                                Description = "This piece of papyrus contains hieroglyphic inscriptions from the New Kingdom period.",
                                Price = 1500.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 7
                            },
                            new Product
                            {
                                ProductId = 12,
                                Name = "Roman Gladius",
                                Description = "This sword was used by the Roman legions during the Republic era.",
                                Price = 2500.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 7
                            },
                            new Product
                            {
                                ProductId = 13,
                                Name = "Medieval Tapestry",
                                Description = "This tapestry depicts scenes from the life of King Arthur and the Knights of the Round Table.",
                                Price = 3500.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 4
                            },
                            new Product
                            {
                                ProductId = 14,
                                Name = "Mayan Codex",
                                Description = "This codex contains information about Mayan astronomy and the sacred calendar.",
                                Price = 5000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 4
                            },
                            new Product
                            {
                                ProductId = 15,
                                Name = "Chinese Jade Sculpture",
                                Description = "This sculpture depicts a dragon and is made of carved jade from the Han dynasty.",
                                Price = 8000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 10
                            },
                            new Product
                            {
                                ProductId = 16,
                                Name = "Byzantine Icon",
                                Description = "This icon depicts the Virgin Mary and dates back to the 10th century CE.",
                                Price = 12000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 6
                            },
                            new Product
                            {
                                ProductId = 17,
                                Name = "Renaissance Portrait",
                                Description = "This portrait depicts a member of the Medici family and was painted by a famous Renaissance artist.",
                                Price = 20000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 2
                            },
                            new Product
                            {
                                ProductId = 18,
                                Name = "Aztec Gold Mask",
                                Description = "This mask was worn by Aztec rulers and is made of solid gold.",
                                Price = 35000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 7
                            },
                            new Product
                            {
                                ProductId = 19,
                                Name = "Japanese Samurai Armor",
                                Description = "This armor belonged to a samurai from the Edo period and is made of lacquered iron plates.",
                                Price = 50000.00M,
                                Status = ProductStatus.ForSale,
                                SellerId = 2
                            },
                            new Product
                            {
                                ProductId = 20,
                                Name = "Ming Dynasty Vase",
                                Description = "This vase is from the early Ming dynasty and is decorated with blue and white porcelain.",
                                Price = 75000.00M,
                                Status = ProductStatus.ForSale,
                                Seller = new User { UserId = 10}, 

                            }
                            ) ;

            //builder.HasOne(p => p.Seller)
            //       .WithMany()
            //       .HasForeignKey(p => p.SellerId);
        }

    }
}
