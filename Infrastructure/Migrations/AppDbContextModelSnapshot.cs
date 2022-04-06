﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ApplicationCore.Entity.Asset.BankSavingAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BankCode")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsGoingToReinState")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int>("TermRange")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("BankSavingAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CashAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("CurrentAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("CashAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Crypto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CryptoCoinCode")
                        .HasColumnType("text");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Cryptos");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CustomInterestAssetInfoId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("InterestRate")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<int>("TermRange")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomInterestAssetInfoId");

                    b.HasIndex("PortfolioId");

                    b.ToTable("CustomInterestAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CustomInterestAssetInfos");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.RealEstateAsset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("RealEstateAssets");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("CurrentAmountHolding")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("InputCurrency")
                        .HasColumnType("text");

                    b.Property<DateTime>("InputDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("InputMoneyAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MarketCode")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("integer");

                    b.Property<string>("StockCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PortfolioId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Portfolio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("InitialCash")
                        .HasColumnType("numeric");

                    b.Property<string>("InitialCurrency")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Transactions.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("LastChanged")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("SourceAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("SourceType")
                        .HasColumnType("text");

                    b.Property<int>("TargetAssetId")
                        .HasColumnType("integer");

                    b.Property<string>("TargetType")
                        .HasColumnType("text");

                    b.Property<int>("TransactionType")
                        .HasColumnType("integer");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<decimal>("ValueByUsd")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ApplicationCore.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.BankSavingAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CashAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Crypto", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", "CustomInterestAssetInfo")
                        .WithMany()
                        .HasForeignKey("CustomInterestAssetInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomInterestAssetInfo");

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.CustomInterestAssetInfo", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.RealEstateAsset", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Asset.Stock", b =>
                {
                    b.HasOne("ApplicationCore.Entity.Portfolio", "Portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Portfolio");
                });

            modelBuilder.Entity("ApplicationCore.Entity.Portfolio", b =>
                {
                    b.HasOne("ApplicationCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
