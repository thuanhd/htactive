﻿// <auto-generated />
using HTActive.Common;
using HTActive.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HTActive.Web.Migrations
{
    [DbContext(typeof(InstanceEntities))]
    partial class InstanceEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("HTActive.Entities.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("HTActive.Entities.ContentFooter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutUsHref")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsText")
                        .HasMaxLength(512);

                    b.Property<string>("Address")
                        .HasMaxLength(512);

                    b.Property<string>("Address2")
                        .HasMaxLength(512);

                    b.Property<string>("Content1")
                        .HasMaxLength(512);

                    b.Property<string>("CopyRight")
                        .HasMaxLength(512);

                    b.Property<string>("Email")
                        .HasMaxLength(512);

                    b.Property<string>("Facebook")
                        .HasMaxLength(512);

                    b.Property<string>("Flickr")
                        .HasMaxLength(512);

                    b.Property<string>("GooglePlus")
                        .HasMaxLength(512);

                    b.Property<int?>("Language");

                    b.Property<string>("LinkedIn")
                        .HasMaxLength(512);

                    b.Property<string>("Mobile")
                        .HasMaxLength(512);

                    b.Property<string>("Phone")
                        .HasMaxLength(512);

                    b.Property<string>("Pinterest")
                        .HasMaxLength(512);

                    b.Property<string>("Skype")
                        .HasMaxLength(512);

                    b.Property<string>("Slogan")
                        .HasMaxLength(512);

                    b.Property<string>("Twitter")
                        .HasMaxLength(512);

                    b.Property<string>("YouTube")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.ToTable("ContentFooter");
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutUsContent")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsLeftContent")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsLeftSrc")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsLeftSubContent")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsLeftTitle")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsLeftUrl")
                        .HasMaxLength(512);

                    b.Property<string>("AboutUsTitle")
                        .HasMaxLength(512);

                    b.Property<string>("ButtonContact")
                        .HasMaxLength(512);

                    b.Property<string>("ButtonReadMore")
                        .HasMaxLength(512);

                    b.Property<string>("ContactContent")
                        .HasMaxLength(512);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(512);

                    b.Property<string>("FeatureContent")
                        .HasMaxLength(512);

                    b.Property<string>("FeatureTitle")
                        .HasMaxLength(512);

                    b.Property<int?>("Language");

                    b.Property<string>("PolicyContent")
                        .HasMaxLength(512);

                    b.Property<string>("PolicyTitle")
                        .HasMaxLength(512);

                    b.Property<string>("WhyChooseContent")
                        .HasMaxLength(512);

                    b.Property<string>("WhyChooseTitle")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.ToTable("ContentIndex");
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexAboutUsRight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(512);

                    b.Property<int?>("ContentIndexId");

                    b.Property<string>("Icon")
                        .HasMaxLength(512);

                    b.Property<int?>("Priority");

                    b.Property<string>("Title")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("ContentIndexId");

                    b.ToTable("ContentIndexAboutUsRight");
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(512);

                    b.Property<int?>("ContentIndexId");

                    b.Property<string>("Icon")
                        .HasMaxLength(512);

                    b.Property<int?>("Priority");

                    b.Property<string>("Title")
                        .HasMaxLength(512);

                    b.Property<string>("Url")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("ContentIndexId");

                    b.ToTable("ContentIndexFeature");
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexTopSlide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContentIndexId");

                    b.Property<string>("MainImageAlt")
                        .HasMaxLength(512);

                    b.Property<string>("MainImageSrc")
                        .HasMaxLength(512);

                    b.Property<int?>("Priority");

                    b.Property<string>("RightImageAlt")
                        .HasMaxLength(512);

                    b.Property<string>("RightImageSrc")
                        .HasMaxLength(512);

                    b.Property<string>("SlideContents")
                        .HasMaxLength(512);

                    b.Property<string>("SlideFooter")
                        .HasMaxLength(512);

                    b.Property<string>("SlideTitle")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("ContentIndexId");

                    b.ToTable("ContentIndexTopSlide");
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexWhyChoose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(512);

                    b.Property<int?>("ContentIndexId");

                    b.Property<int?>("Priority");

                    b.Property<string>("Src")
                        .HasMaxLength(512);

                    b.Property<string>("SubTitle")
                        .HasMaxLength(512);

                    b.Property<string>("Title")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("ContentIndexId");

                    b.ToTable("ContentIndexWhyChoose");
                });

            modelBuilder.Entity("HTActive.Entities.ContentMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContentFooterId");

                    b.Property<string>("Link")
                        .HasMaxLength(512);

                    b.Property<int?>("Priority");

                    b.Property<string>("Tab")
                        .HasMaxLength(512);

                    b.Property<string>("Text")
                        .HasMaxLength(512);

                    b.HasKey("Id");

                    b.HasIndex("ContentFooterId");

                    b.ToTable("ContentMenu");
                });

            modelBuilder.Entity("HTActive.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("S3FileKey")
                        .HasMaxLength(256);

                    b.Property<string>("Url")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("HTActive.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<int>("RoleType");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("HTActive.Entities.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClaimId");

                    b.Property<int?>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("HTActive.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<string>("Password")
                        .HasMaxLength(256);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(256);

                    b.Property<string>("ProviderName")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int?>("UserStatusId");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HTActive.Entities.UserLoginToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpiredDated");

                    b.Property<bool?>("IsRememberMe");

                    b.Property<DateTime>("LastLoginDated");

                    b.Property<string>("Token")
                        .HasMaxLength(256);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLoginToken");
                });

            modelBuilder.Entity("HTActive.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(256);

                    b.Property<int?>("AvatarId");

                    b.Property<string>("City")
                        .HasMaxLength(256);

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<string>("FirstName")
                        .HasMaxLength(256);

                    b.Property<string>("LastName")
                        .HasMaxLength(256);

                    b.Property<int?>("UserId");

                    b.Property<bool?>("WasVerifiedEmail");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("HTActive.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RoleId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexAboutUsRight", b =>
                {
                    b.HasOne("HTActive.Entities.ContentIndex", "ContentIndex")
                        .WithMany("AboutUsRights")
                        .HasForeignKey("ContentIndexId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexFeature", b =>
                {
                    b.HasOne("HTActive.Entities.ContentIndex", "ContentIndex")
                        .WithMany("Features")
                        .HasForeignKey("ContentIndexId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexTopSlide", b =>
                {
                    b.HasOne("HTActive.Entities.ContentIndex", "ContentIndex")
                        .WithMany("TopSlides")
                        .HasForeignKey("ContentIndexId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.ContentIndexWhyChoose", b =>
                {
                    b.HasOne("HTActive.Entities.ContentIndex", "ContentIndex")
                        .WithMany("WhyChooseReasons")
                        .HasForeignKey("ContentIndexId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.ContentMenu", b =>
                {
                    b.HasOne("HTActive.Entities.ContentFooter", "ContentFooter")
                        .WithMany("ContentMenus")
                        .HasForeignKey("ContentFooterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.RoleClaim", b =>
                {
                    b.HasOne("HTActive.Entities.Claim", "Claim")
                        .WithMany("RoleClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HTActive.Entities.Role", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.UserLoginToken", b =>
                {
                    b.HasOne("HTActive.Entities.User", "User")
                        .WithMany("UserLoginTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.UserProfile", b =>
                {
                    b.HasOne("HTActive.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("HTActive.Entities.User", "User")
                        .WithMany("UserProfiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTActive.Entities.UserRole", b =>
                {
                    b.HasOne("HTActive.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId");

                    b.HasOne("HTActive.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
