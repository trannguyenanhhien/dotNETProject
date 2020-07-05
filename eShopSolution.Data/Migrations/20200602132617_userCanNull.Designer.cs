﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eShopSolution.Data.EF;

namespace eShopSolution.Data.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20200602132617_userCanNull")]
    partial class userCanNull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_At")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UserAppId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserAppId");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_At = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 20000m,
                            UserId = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = 2,
                            Created_At = new DateTime(2020, 6, 2, 20, 26, 16, 711, DateTimeKind.Local).AddTicks(5041),
                            Price = 0m,
                            UserId = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de")
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CartProduct", b =>
                {
                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartProducts");

                    b.HasData(
                        new
                        {
                            CartID = 1,
                            ProductID = 1,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_At")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsShowOnHome")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_At = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsShowOnHome = true,
                            Status = 1
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CategoryTranslation", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CategoryTranslations");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            LanguageId = "vn",
                            CategoryUrl = "banh-ngot",
                            Name = "Bánh ngọt"
                        },
                        new
                        {
                            CategoryId = 1,
                            LanguageId = "en",
                            CategoryUrl = "cake",
                            Name = "Cake"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_At")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "hieuvo044@gmail.com",
                            Message = "Very good",
                            Name = "Võ Trung Hiếu"
                        },
                        new
                        {
                            Id = 2,
                            Email = "hieuvo044@gmail.com",
                            Message = "Very good",
                            Name = "Phuong Quyen"
                        },
                        new
                        {
                            Id = 3,
                            Email = "hieuvo044@gmail.com",
                            Message = "Very good",
                            Name = "Võ Trung Hiếu"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = "vn",
                            IsDefault = false,
                            Name = "VIETNAM"
                        },
                        new
                        {
                            Id = "en",
                            IsDefault = false,
                            Name = "ENGLISH"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Like", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created_At")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("OrderNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PromotionId")
                        .HasColumnType("int");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PromotionId")
                        .IsUnique()
                        .HasFilter("[PromotionId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_At")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Created_At = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OriginalPrice = 17000m,
                            Price = 20000m,
                            Stock = 0
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDefault")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Caption = "!23",
                            FileSize = 0L,
                            ImagePath = "http://product.hstatic.net/1000026716/product/81ax00mcvn_bd76b8bf0aed4307bc9714e4dc5830f0_large.jpg",
                            IsDefault = true,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Caption = "!23",
                            FileSize = 0L,
                            ImagePath = "http://product.hstatic.net/1000026716/product/81ax00mcvn_bd76b8bf0aed4307bc9714e4dc5830f0_large.jpg",
                            IsDefault = false,
                            ProductId = 1
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductTranslation", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("LanguageId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("ProductTranslations");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            LanguageId = "vn",
                            Description = "This is banh ngot 1",
                            Name = "Bánh ngọt1",
                            ProductUrl = "banh-ngot1"
                        },
                        new
                        {
                            ProductId = 1,
                            LanguageId = "en",
                            Description = "This is cake1",
                            Name = "Cake1",
                            ProductUrl = "cake1"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DiscountAmount")
                        .HasColumnType("int");

                    b.Property<int>("DiscountPercent")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasAlternateKey("Code");

                    b.ToTable("Promotions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "123",
                            DiscountAmount = 10000,
                            DiscountPercent = 0,
                            FromDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ToDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Code = "1234",
                            DiscountAmount = 20000,
                            DiscountPercent = 0,
                            FromDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ToDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created_At")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.RoleApp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            ConcurrencyStamp = "b9ee59e8-8970-412b-b5f6-24f392ba1ce6",
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = new Guid("8d04dce2-969a-435d-bba4-df3f325983dd"),
                            ConcurrencyStamp = "81a37b00-ad00-4c78-8919-097b1b9ec434",
                            Description = "Client role",
                            Name = "client",
                            NormalizedName = "client"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.UserApp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid>("RoleID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ea5092e9-a35d-46d6-83aa-4967310b9cf1",
                            Dob = new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hieuvo044@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "hieuvo044@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEJJgSFcQa2dJ2eJfKUgud9dXTRR+sm0+dw40UmvFAESozKy+68x/W+ywI/xh35g9oQ==",
                            PhoneNumberConfirmed = false,
                            RoleID = new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Blog", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Categories")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.UserApp", "UserApp")
                        .WithMany("Blogs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Cart", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.UserApp", "UserApp")
                        .WithMany("Carts")
                        .HasForeignKey("UserAppId");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CartProduct", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.CategoryTranslation", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Category")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Language", "Language")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Comment", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.UserApp", "UserApp")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Like", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.UserApp", "UserApp")
                        .WithMany("Likes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Order", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Promotion", "Promotion")
                        .WithOne("Order")
                        .HasForeignKey("eShopSolution.Data.Entities.Order", "PromotionId");

                    b.HasOne("eShopSolution.Data.Entities.UserApp", "UserApp")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithOne("OrderDetail")
                        .HasForeignKey("eShopSolution.Data.Entities.OrderDetail", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.Product", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.ProductTranslation", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.Language", "Language")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eShopSolution.Data.Entities.Product", "Product")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eShopSolution.Data.Entities.UserApp", b =>
                {
                    b.HasOne("eShopSolution.Data.Entities.RoleApp", "RoleApp")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
