﻿// <auto-generated />
using DDDSample1.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DDDNetCore.Migrations
{
    [DbContext(typeof(DDDSample1DbContext))]
    [Migration("20221031191149_NomeDaMigracao")]
    partial class NomeDaMigracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DDDSample1.Domain.Armazens.Armazem", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Armazens");
                });

            modelBuilder.Entity("DDDSample1.Domain.Entregas.Entrega", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("armazemEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dataEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("massaEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tempoColocarEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tempoRetirarEntrega")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("DDDSample1.Domain.Armazens.Armazem", b =>
                {
                    b.OwnsOne("DDDSample1.Domain.Armazens.ArmazemCoordenadas", "Coordenadas", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<int>("CoordenadaLat")
                                .HasColumnType("int");

                            b1.Property<int>("CoordenadaLon")
                                .HasColumnType("int");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.ArmazemDesignacao", "Designacao", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Designacao")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.OwnsOne("DDDSample1.Domain.Armazens.ArmazemEndereco", "Endereco", b1 =>
                        {
                            b1.Property<string>("ArmazemId")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("Cidade")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("CodigoPostal")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("NumeroPorta")
                                .HasColumnType("int");

                            b1.Property<string>("Pais")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Rua")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ArmazemId");

                            b1.ToTable("Armazens");

                            b1.WithOwner()
                                .HasForeignKey("ArmazemId");
                        });

                    b.Navigation("Coordenadas");

                    b.Navigation("Designacao");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}