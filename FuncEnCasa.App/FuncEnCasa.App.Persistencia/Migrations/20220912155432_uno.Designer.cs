// <auto-generated />
using System;
using FuncEnCasa.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FuncEnCasa.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20220912155432_uno")]
    partial class uno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Area", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdArea")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreArea")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreArea")
                        .IsUnique();

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Barrio", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdBarrio")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreBarrio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreBarrio")
                        .IsUnique();

                    b.ToTable("Barrios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Barrio_ZonaLocalidad", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdBarrioZL")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ZonaLId")
                        .HasColumnType("int");

                    b.Property<int?>("barrioId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("ZonaLId");

                    b.HasIndex("barrioId");

                    b.ToTable("Barri_ZonaLocalidades");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCiudad")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreCiudad")
                        .IsUnique();

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad_BarrioZonaLocalidad", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCiudadBZL")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BarrioZLId")
                        .HasColumnType("int");

                    b.Property<int?>("ciudadId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("BarrioZLId");

                    b.HasIndex("ciudadId");

                    b.ToTable("Ciudad_BarrioZonaLocalidades");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad_Departamento", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCiudadDepartamento")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ciudadId")
                        .HasColumnType("int");

                    b.Property<int?>("departamentoId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("ciudadId");

                    b.HasIndex("departamentoId");

                    b.ToTable("Ciudad_Departamentos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Correo", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCorreo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("idTipoContacto")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("correo", "idTipoContacto")
                        .IsUnique();

                    b.ToTable("Correos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Correo_Usuario", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCorreoU")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CorreoId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("CorreoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("CorreoUsuarios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Departamento", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDepartamento")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreDepart")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreDepart")
                        .IsUnique();

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Direccion", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDireccion")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("tipoViviendaId")
                        .HasColumnType("int");

                    b.Property<int?>("tipoVivienda_Barrio_Id")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("direccion")
                        .IsUnique();

                    b.HasIndex("tipoVivienda_Barrio_Id");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Funcionario", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdFuncionario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("areaId")
                        .HasColumnType("int");

                    b.Property<int?>("ciudadBId")
                        .HasColumnType("int");

                    b.Property<int?>("ciudad_BarrioZonaLocalidad_Id")
                        .HasColumnType("int");

                    b.Property<int?>("correoId")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("int");

                    b.Property<int?>("direccionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<int?>("jerarquiaId")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("sucursalId")
                        .HasColumnType("int");

                    b.Property<int?>("telefonoId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("tipoSanguineo")
                        .HasColumnType("int");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("areaId");

                    b.HasIndex("ciudad_BarrioZonaLocalidad_Id");

                    b.HasIndex("correoId");

                    b.HasIndex("direccionId");

                    b.HasIndex("jerarquiaId");

                    b.HasIndex("sucursalId");

                    b.HasIndex("telefonoId");

                    b.HasIndex("usuarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Jerarquia", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdJerarquia")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreJerarquia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreJerarquia")
                        .IsUnique();

                    b.ToTable("Jerarquias");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Pais", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPais")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombrePais")
                        .IsUnique();

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Pais_Departamento", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDepartamentoPais")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("departamentoId")
                        .HasColumnType("int");

                    b.Property<int?>("paisId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("departamentoId");

                    b.HasIndex("paisId");

                    b.ToTable("Pais_Departamentos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Sector", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdSector")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreSector")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreSector")
                        .IsUnique();

                    b.ToTable("Sectores");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Sucursal", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdSucursal")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ciudadId")
                        .HasColumnType("int");

                    b.Property<string>("nombreSucursal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("ciudadId");

                    b.HasIndex("nombreSucursal")
                        .IsUnique();

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Telefono", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTelefono")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idTipoContacto")
                        .HasColumnType("int");

                    b.Property<long>("numeroTel")
                        .HasColumnType("bigint");

                    b.HasKey("_Id");

                    b.HasIndex("numeroTel", "idTipoContacto")
                        .IsUnique();

                    b.ToTable("Telefonos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Telefono_Usuario", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTelefonoU")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("TelefonoId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("TelefonoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TelefonoUsuarios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.TipoVivienda", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTipoViVienda")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("descripcion")
                        .IsUnique();

                    b.ToTable("TipoViviendas");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.TipoVivienda_Barrio", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTipoViviendaB")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Ciudad_BarrioZonaLocalidad_Id")
                        .HasColumnType("int");

                    b.Property<int?>("ciudadBId")
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("tipoViViendaId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("Ciudad_BarrioZonaLocalidad_Id");

                    b.HasIndex("tipoViViendaId");

                    b.ToTable("TipoVivienda_Barrios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdUsuario")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idTipoDocumento")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Zona", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdZona")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreZona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("_Id");

                    b.HasIndex("nombreZona")
                        .IsUnique();

                    b.ToTable("Zonas");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Zona_Localidad", b =>
                {
                    b.Property<int>("_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdZonaSector")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("sectorId")
                        .HasColumnType("int");

                    b.Property<int?>("zonaId")
                        .HasColumnType("int");

                    b.HasKey("_Id");

                    b.HasIndex("sectorId");

                    b.HasIndex("zonaId");

                    b.ToTable("Zona_Localidades");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Barrio_ZonaLocalidad", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Zona_Localidad", "zonaL")
                        .WithMany("barrioZonaSector")
                        .HasForeignKey("ZonaLId");

                    b.HasOne("FuncEnCasa.App.Dominio.Barrio", "barrio")
                        .WithMany("barrioZonaSector")
                        .HasForeignKey("barrioId");

                    b.Navigation("barrio");

                    b.Navigation("zonaL");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad_BarrioZonaLocalidad", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Barrio_ZonaLocalidad", "barrioZL")
                        .WithMany("ciudadBarrioZonaLocalidad")
                        .HasForeignKey("BarrioZLId");

                    b.HasOne("FuncEnCasa.App.Dominio.Ciudad", "ciudad")
                        .WithMany("ciudadBarrioZonaLocalidad")
                        .HasForeignKey("ciudadId");

                    b.Navigation("barrioZL");

                    b.Navigation("ciudad");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad_Departamento", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Ciudad", "ciudad")
                        .WithMany("ciudadDepartamento")
                        .HasForeignKey("ciudadId");

                    b.HasOne("FuncEnCasa.App.Dominio.Departamento", "departamento")
                        .WithMany("ciudadDepartamento")
                        .HasForeignKey("departamentoId");

                    b.Navigation("ciudad");

                    b.Navigation("departamento");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Correo_Usuario", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Correo", "correo")
                        .WithMany("correoUsuario")
                        .HasForeignKey("CorreoId");

                    b.HasOne("FuncEnCasa.App.Dominio.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("correo");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Direccion", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.TipoVivienda_Barrio", "tipoVivienda_Barrio")
                        .WithMany("direccionDos")
                        .HasForeignKey("tipoVivienda_Barrio_Id");

                    b.Navigation("tipoVivienda_Barrio");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Funcionario", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Area", "area")
                        .WithMany("Funcionario")
                        .HasForeignKey("areaId");

                    b.HasOne("FuncEnCasa.App.Dominio.Ciudad_BarrioZonaLocalidad", "ciudad_BarrioZonaLocalidad")
                        .WithMany("funcionario")
                        .HasForeignKey("ciudad_BarrioZonaLocalidad_Id");

                    b.HasOne("FuncEnCasa.App.Dominio.Correo_Usuario", "correo")
                        .WithMany("funcionarios")
                        .HasForeignKey("correoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FuncEnCasa.App.Dominio.Direccion", "direccion")
                        .WithMany("funcionario")
                        .HasForeignKey("direccionId");

                    b.HasOne("FuncEnCasa.App.Dominio.Jerarquia", "jerarquia")
                        .WithMany("funcionario")
                        .HasForeignKey("jerarquiaId");

                    b.HasOne("FuncEnCasa.App.Dominio.Sucursal", "sucursal")
                        .WithMany("funcionario")
                        .HasForeignKey("sucursalId");

                    b.HasOne("FuncEnCasa.App.Dominio.Telefono_Usuario", "telefono")
                        .WithMany("funcionarios")
                        .HasForeignKey("telefonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FuncEnCasa.App.Dominio.Usuario", "usuario")
                        .WithMany("funcionario")
                        .HasForeignKey("usuarioId");

                    b.Navigation("area");

                    b.Navigation("ciudad_BarrioZonaLocalidad");

                    b.Navigation("correo");

                    b.Navigation("direccion");

                    b.Navigation("jerarquia");

                    b.Navigation("sucursal");

                    b.Navigation("telefono");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Pais_Departamento", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Departamento", "departamento")
                        .WithMany("paisDepartamento")
                        .HasForeignKey("departamentoId");

                    b.HasOne("FuncEnCasa.App.Dominio.Pais", "pais")
                        .WithMany("paisDepartamentos")
                        .HasForeignKey("paisId");

                    b.Navigation("departamento");

                    b.Navigation("pais");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Sucursal", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Ciudad", "ciudad")
                        .WithMany("sucursal")
                        .HasForeignKey("ciudadId");

                    b.Navigation("ciudad");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Telefono_Usuario", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Telefono", "telefono")
                        .WithMany("usuario")
                        .HasForeignKey("TelefonoId");

                    b.HasOne("FuncEnCasa.App.Dominio.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("telefono");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.TipoVivienda_Barrio", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Ciudad_BarrioZonaLocalidad", "Ciudad_BarrioZonaLocalidad")
                        .WithMany("tViviendaBarrio")
                        .HasForeignKey("Ciudad_BarrioZonaLocalidad_Id");

                    b.HasOne("FuncEnCasa.App.Dominio.TipoVivienda", "tipoVivienda")
                        .WithMany("tViviendaBarrio")
                        .HasForeignKey("tipoViViendaId");

                    b.Navigation("Ciudad_BarrioZonaLocalidad");

                    b.Navigation("tipoVivienda");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Zona_Localidad", b =>
                {
                    b.HasOne("FuncEnCasa.App.Dominio.Sector", "sector")
                        .WithMany("zonaLocalidad")
                        .HasForeignKey("sectorId");

                    b.HasOne("FuncEnCasa.App.Dominio.Zona", "zona")
                        .WithMany("zonaLocalidad")
                        .HasForeignKey("zonaId");

                    b.Navigation("sector");

                    b.Navigation("zona");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Area", b =>
                {
                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Barrio", b =>
                {
                    b.Navigation("barrioZonaSector");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Barrio_ZonaLocalidad", b =>
                {
                    b.Navigation("ciudadBarrioZonaLocalidad");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad", b =>
                {
                    b.Navigation("ciudadBarrioZonaLocalidad");

                    b.Navigation("ciudadDepartamento");

                    b.Navigation("sucursal");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Ciudad_BarrioZonaLocalidad", b =>
                {
                    b.Navigation("funcionario");

                    b.Navigation("tViviendaBarrio");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Correo", b =>
                {
                    b.Navigation("correoUsuario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Correo_Usuario", b =>
                {
                    b.Navigation("funcionarios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Departamento", b =>
                {
                    b.Navigation("ciudadDepartamento");

                    b.Navigation("paisDepartamento");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Direccion", b =>
                {
                    b.Navigation("funcionario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Jerarquia", b =>
                {
                    b.Navigation("funcionario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Pais", b =>
                {
                    b.Navigation("paisDepartamentos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Sector", b =>
                {
                    b.Navigation("zonaLocalidad");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Sucursal", b =>
                {
                    b.Navigation("funcionario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Telefono", b =>
                {
                    b.Navigation("usuario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Telefono_Usuario", b =>
                {
                    b.Navigation("funcionarios");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.TipoVivienda", b =>
                {
                    b.Navigation("tViviendaBarrio");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.TipoVivienda_Barrio", b =>
                {
                    b.Navigation("direccionDos");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Usuario", b =>
                {
                    b.Navigation("funcionario");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Zona", b =>
                {
                    b.Navigation("zonaLocalidad");
                });

            modelBuilder.Entity("FuncEnCasa.App.Dominio.Zona_Localidad", b =>
                {
                    b.Navigation("barrioZonaSector");
                });
#pragma warning restore 612, 618
        }
    }
}
