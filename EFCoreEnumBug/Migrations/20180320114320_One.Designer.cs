﻿// <auto-generated />
using System;
using EFCoreEnumBug;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace EFCoreEnumBug.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180320114320_One")]
    partial class One
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-preview1-28290")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreEnumBug.ExchangeRate", b =>
                {
                    b.Property<int>("FromCurrency")
                        .HasConversion<string>();

                    b.Property<int>("ToCurrency")
                        .HasConversion<string>();

                    b.Property<decimal>("Rate");

                    b.HasKey("FromCurrency", "ToCurrency");

                    b.ToTable("ExchangeRate");
                });
#pragma warning restore 612, 618
        }
    }
}