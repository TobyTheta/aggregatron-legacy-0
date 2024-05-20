﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.TimescaleDb;

#nullable disable

namespace Persistence.TimescaleDb.Migrations
{
    [DbContext(typeof(AggregatronPersistenceContext))]
    partial class AggregatronDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Platforms.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AllowsTrading")
                        .HasColumnType("boolean")
                        .HasColumnName("allows_trading");

                    b.Property<bool>("HasCryptoApi")
                        .HasColumnType("boolean")
                        .HasColumnName("has_crypto_api");

                    b.Property<bool>("HasEquitiesApi")
                        .HasColumnType("boolean")
                        .HasColumnName("has_equities_api");

                    b.Property<bool>("HasUserAccounts")
                        .HasColumnType("boolean")
                        .HasColumnName("has_user_accounts");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("ident");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("name");

                    b.Property<bool>("RequiresApiKey")
                        .HasColumnType("boolean")
                        .HasColumnName("requires_api_key");

                    b.Property<bool>("RequiresApiPassword")
                        .HasColumnType("boolean")
                        .HasColumnName("requires_api_password");

                    b.Property<bool>("RequiresApiSecret")
                        .HasColumnType("boolean")
                        .HasColumnName("requires_api_secret");

                    b.Property<DateTimeOffset?>("ValidFrom")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("valid_from");

                    b.Property<DateTimeOffset?>("ValidTo")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("valid_to");

                    b.HasKey("Id");

                    b.ToTable("platform");
                });
#pragma warning restore 612, 618
        }
    }
}