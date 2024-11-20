﻿// <auto-generated />
using System;
using LibreLancer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibreLancer.Database.Migrations
{
    [DbContext(typeof(LibreLancerContext))]
    partial class LibreLancerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("LibreLancer.Entities.Character.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("AccountIdentifier")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BanExpiry")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AccountIdentifier");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.CargoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hardpoint")
                        .HasColumnType("TEXT");

                    b.Property<float>("Health")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsMissionItem")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ItemCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("CargoItem");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.Character", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AccountId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Affiliation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AffiliationLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Base")
                        .HasColumnType("TEXT");

                    b.Property<long>("CapitalKills")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ComCostume")
                        .HasColumnType("TEXT");

                    b.Property<string>("Costume")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<long>("FightersKilled")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MissionsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MissionsFailed")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Money")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT COLLATE NOCASE");

                    b.Property<long>("PlayersKilled")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Rank")
                        .HasColumnType("INTEGER");

                    b.Property<float>("RotationW")
                        .HasColumnType("REAL");

                    b.Property<float>("RotationX")
                        .HasColumnType("REAL");

                    b.Property<float>("RotationY")
                        .HasColumnType("REAL");

                    b.Property<float>("RotationZ")
                        .HasColumnType("REAL");

                    b.Property<string>("Ship")
                        .HasColumnType("TEXT");

                    b.Property<string>("System")
                        .HasColumnType("TEXT");

                    b.Property<long>("TransportsKilled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Voice")
                        .HasColumnType("TEXT");

                    b.Property<float>("X")
                        .HasColumnType("REAL");

                    b.Property<float>("Y")
                        .HasColumnType("REAL");

                    b.Property<float>("Z")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.Reputation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("RepGroup")
                        .HasColumnType("TEXT");

                    b.Property<float>("ReputationValue")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Reputation");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.VisitEntry", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SolarNickname")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("VisitValue")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("VisitEntry");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.CargoItem", b =>
                {
                    b.HasOne("LibreLancer.Entities.Character.Character", null)
                        .WithMany("Items")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.Character", b =>
                {
                    b.HasOne("LibreLancer.Entities.Character.Account", "Account")
                        .WithMany("Characters")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.Reputation", b =>
                {
                    b.HasOne("LibreLancer.Entities.Character.Character", null)
                        .WithMany("Reputations")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.VisitEntry", b =>
                {
                    b.HasOne("LibreLancer.Entities.Character.Character", null)
                        .WithMany("VisitEntries")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.Account", b =>
                {
                    b.Navigation("Characters");
                });

            modelBuilder.Entity("LibreLancer.Entities.Character.Character", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("Reputations");

                    b.Navigation("VisitEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
