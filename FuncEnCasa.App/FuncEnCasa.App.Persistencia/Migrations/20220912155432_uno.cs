using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FuncEnCasa.App.Persistencia.Migrations
{
    public partial class uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    IdArea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreArea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.IdArea);
                });

            migrationBuilder.CreateTable(
                name: "Barrios",
                columns: table => new
                {
                    IdBarrio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreBarrio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrios", x => x.IdBarrio);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCiudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCiudad);
                });

            migrationBuilder.CreateTable(
                name: "Correos",
                columns: table => new
                {
                    IdCorreo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTipoContacto = table.Column<int>(type: "int", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correos", x => x.IdCorreo);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDepart = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.IdDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "Jerarquias",
                columns: table => new
                {
                    IdJerarquia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreJerarquia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jerarquias", x => x.IdJerarquia);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    IdSector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreSector = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.IdSector);
                });

            migrationBuilder.CreateTable(
                name: "Telefonos",
                columns: table => new
                {
                    IdTelefono = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTipoContacto = table.Column<int>(type: "int", nullable: false),
                    numeroTel = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefonos", x => x.IdTelefono);
                });

            migrationBuilder.CreateTable(
                name: "TipoViviendas",
                columns: table => new
                {
                    IdTipoViVienda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoViviendas", x => x.IdTipoViVienda);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idTipoDocumento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    IdZona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreZona = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.IdZona);
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    IdSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreSucursal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ciudadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IdSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursales_Ciudades_ciudadId",
                        column: x => x.ciudadId,
                        principalTable: "Ciudades",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad_Departamentos",
                columns: table => new
                {
                    IdCiudadDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciudadId = table.Column<int>(type: "int", nullable: true),
                    departamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad_Departamentos", x => x.IdCiudadDepartamento);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamentos_Ciudades_ciudadId",
                        column: x => x.ciudadId,
                        principalTable: "Ciudades",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamentos_Departamentos_departamentoId",
                        column: x => x.departamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pais_Departamentos",
                columns: table => new
                {
                    IdDepartamentoPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paisId = table.Column<int>(type: "int", nullable: true),
                    departamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais_Departamentos", x => x.IdDepartamentoPais);
                    table.ForeignKey(
                        name: "FK_Pais_Departamentos_Departamentos_departamentoId",
                        column: x => x.departamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pais_Departamentos_Paises_paisId",
                        column: x => x.paisId,
                        principalTable: "Paises",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CorreoUsuarios",
                columns: table => new
                {
                    IdCorreoU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorreoId = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorreoUsuarios", x => x.IdCorreoU);
                    table.ForeignKey(
                        name: "FK_CorreoUsuarios_Correos_CorreoId",
                        column: x => x.CorreoId,
                        principalTable: "Correos",
                        principalColumn: "IdCorreo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CorreoUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TelefonoUsuarios",
                columns: table => new
                {
                    IdTelefonoU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonoId = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonoUsuarios", x => x.IdTelefonoU);
                    table.ForeignKey(
                        name: "FK_TelefonoUsuarios_Telefonos_TelefonoId",
                        column: x => x.TelefonoId,
                        principalTable: "Telefonos",
                        principalColumn: "IdTelefono",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TelefonoUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zona_Localidades",
                columns: table => new
                {
                    IdZonaSector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    zonaId = table.Column<int>(type: "int", nullable: true),
                    sectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zona_Localidades", x => x.IdZonaSector);
                    table.ForeignKey(
                        name: "FK_Zona_Localidades_Sectores_sectorId",
                        column: x => x.sectorId,
                        principalTable: "Sectores",
                        principalColumn: "IdSector",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zona_Localidades_Zonas_zonaId",
                        column: x => x.zonaId,
                        principalTable: "Zonas",
                        principalColumn: "IdZona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Barri_ZonaLocalidades",
                columns: table => new
                {
                    IdBarrioZL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    barrioId = table.Column<int>(type: "int", nullable: true),
                    ZonaLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barri_ZonaLocalidades", x => x.IdBarrioZL);
                    table.ForeignKey(
                        name: "FK_Barri_ZonaLocalidades_Barrios_barrioId",
                        column: x => x.barrioId,
                        principalTable: "Barrios",
                        principalColumn: "IdBarrio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Barri_ZonaLocalidades_Zona_Localidades_ZonaLId",
                        column: x => x.ZonaLId,
                        principalTable: "Zona_Localidades",
                        principalColumn: "IdZonaSector",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad_BarrioZonaLocalidades",
                columns: table => new
                {
                    IdCiudadBZL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciudadId = table.Column<int>(type: "int", nullable: true),
                    BarrioZLId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad_BarrioZonaLocalidades", x => x.IdCiudadBZL);
                    table.ForeignKey(
                        name: "FK_Ciudad_BarrioZonaLocalidades_Barri_ZonaLocalidades_BarrioZLId",
                        column: x => x.BarrioZLId,
                        principalTable: "Barri_ZonaLocalidades",
                        principalColumn: "IdBarrioZL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ciudad_BarrioZonaLocalidades_Ciudades_ciudadId",
                        column: x => x.ciudadId,
                        principalTable: "Ciudades",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipoVivienda_Barrios",
                columns: table => new
                {
                    IdTipoViviendaB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ciudadBId = table.Column<int>(type: "int", nullable: true),
                    Ciudad_BarrioZonaLocalidad_Id = table.Column<int>(type: "int", nullable: true),
                    tipoViViendaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoVivienda_Barrios", x => x.IdTipoViviendaB);
                    table.ForeignKey(
                        name: "FK_TipoVivienda_Barrios_Ciudad_BarrioZonaLocalidades_Ciudad_BarrioZonaLocalidad_Id",
                        column: x => x.Ciudad_BarrioZonaLocalidad_Id,
                        principalTable: "Ciudad_BarrioZonaLocalidades",
                        principalColumn: "IdCiudadBZL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TipoVivienda_Barrios_TipoViviendas_tipoViViendaId",
                        column: x => x.tipoViViendaId,
                        principalTable: "TipoViviendas",
                        principalColumn: "IdTipoViVienda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipoViviendaId = table.Column<int>(type: "int", nullable: true),
                    tipoVivienda_Barrio_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.IdDireccion);
                    table.ForeignKey(
                        name: "FK_Direcciones_TipoVivienda_Barrios_tipoVivienda_Barrio_Id",
                        column: x => x.tipoVivienda_Barrio_Id,
                        principalTable: "TipoVivienda_Barrios",
                        principalColumn: "IdTipoViviendaB",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioId = table.Column<int>(type: "int", nullable: true),
                    nombre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    correoId = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    telefonoId = table.Column<int>(type: "int", nullable: false),
                    tipoSanguineo = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    genero = table.Column<int>(type: "int", nullable: false),
                    areaId = table.Column<int>(type: "int", nullable: true),
                    ciudadBId = table.Column<int>(type: "int", nullable: true),
                    ciudad_BarrioZonaLocalidad_Id = table.Column<int>(type: "int", nullable: true),
                    direccionId = table.Column<int>(type: "int", nullable: true),
                    jerarquiaId = table.Column<int>(type: "int", nullable: true),
                    sucursalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Areas_areaId",
                        column: x => x.areaId,
                        principalTable: "Areas",
                        principalColumn: "IdArea",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Ciudad_BarrioZonaLocalidades_ciudad_BarrioZonaLocalidad_Id",
                        column: x => x.ciudad_BarrioZonaLocalidad_Id,
                        principalTable: "Ciudad_BarrioZonaLocalidades",
                        principalColumn: "IdCiudadBZL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_CorreoUsuarios_correoId",
                        column: x => x.correoId,
                        principalTable: "CorreoUsuarios",
                        principalColumn: "IdCorreoU",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Direcciones_direccionId",
                        column: x => x.direccionId,
                        principalTable: "Direcciones",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Jerarquias_jerarquiaId",
                        column: x => x.jerarquiaId,
                        principalTable: "Jerarquias",
                        principalColumn: "IdJerarquia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Sucursales_sucursalId",
                        column: x => x.sucursalId,
                        principalTable: "Sucursales",
                        principalColumn: "IdSucursal",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_TelefonoUsuarios_telefonoId",
                        column: x => x.telefonoId,
                        principalTable: "TelefonoUsuarios",
                        principalColumn: "IdTelefonoU",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Usuarios_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Areas_nombreArea",
                table: "Areas",
                column: "nombreArea",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Barri_ZonaLocalidades_barrioId",
                table: "Barri_ZonaLocalidades",
                column: "barrioId");

            migrationBuilder.CreateIndex(
                name: "IX_Barri_ZonaLocalidades_ZonaLId",
                table: "Barri_ZonaLocalidades",
                column: "ZonaLId");

            migrationBuilder.CreateIndex(
                name: "IX_Barrios_nombreBarrio",
                table: "Barrios",
                column: "nombreBarrio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_BarrioZonaLocalidades_BarrioZLId",
                table: "Ciudad_BarrioZonaLocalidades",
                column: "BarrioZLId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_BarrioZonaLocalidades_ciudadId",
                table: "Ciudad_BarrioZonaLocalidades",
                column: "ciudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_Departamentos_ciudadId",
                table: "Ciudad_Departamentos",
                column: "ciudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_Departamentos_departamentoId",
                table: "Ciudad_Departamentos",
                column: "departamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_nombreCiudad",
                table: "Ciudades",
                column: "nombreCiudad",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Correos_correo_idTipoContacto",
                table: "Correos",
                columns: new[] { "correo", "idTipoContacto" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CorreoUsuarios_CorreoId",
                table: "CorreoUsuarios",
                column: "CorreoId");

            migrationBuilder.CreateIndex(
                name: "IX_CorreoUsuarios_UsuarioId",
                table: "CorreoUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_nombreDepart",
                table: "Departamentos",
                column: "nombreDepart",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_direccion",
                table: "Direcciones",
                column: "direccion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_tipoVivienda_Barrio_Id",
                table: "Direcciones",
                column: "tipoVivienda_Barrio_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_areaId",
                table: "Funcionarios",
                column: "areaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_ciudad_BarrioZonaLocalidad_Id",
                table: "Funcionarios",
                column: "ciudad_BarrioZonaLocalidad_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_correoId",
                table: "Funcionarios",
                column: "correoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_direccionId",
                table: "Funcionarios",
                column: "direccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_jerarquiaId",
                table: "Funcionarios",
                column: "jerarquiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_sucursalId",
                table: "Funcionarios",
                column: "sucursalId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_telefonoId",
                table: "Funcionarios",
                column: "telefonoId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_usuarioId",
                table: "Funcionarios",
                column: "usuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jerarquias_nombreJerarquia",
                table: "Jerarquias",
                column: "nombreJerarquia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pais_Departamentos_departamentoId",
                table: "Pais_Departamentos",
                column: "departamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pais_Departamentos_paisId",
                table: "Pais_Departamentos",
                column: "paisId");

            migrationBuilder.CreateIndex(
                name: "IX_Paises_nombrePais",
                table: "Paises",
                column: "nombrePais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sectores_nombreSector",
                table: "Sectores",
                column: "nombreSector",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_ciudadId",
                table: "Sucursales",
                column: "ciudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_nombreSucursal",
                table: "Sucursales",
                column: "nombreSucursal",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Telefonos_numeroTel_idTipoContacto",
                table: "Telefonos",
                columns: new[] { "numeroTel", "idTipoContacto" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TelefonoUsuarios_TelefonoId",
                table: "TelefonoUsuarios",
                column: "TelefonoId");

            migrationBuilder.CreateIndex(
                name: "IX_TelefonoUsuarios_UsuarioId",
                table: "TelefonoUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoVivienda_Barrios_Ciudad_BarrioZonaLocalidad_Id",
                table: "TipoVivienda_Barrios",
                column: "Ciudad_BarrioZonaLocalidad_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TipoVivienda_Barrios_tipoViViendaId",
                table: "TipoVivienda_Barrios",
                column: "tipoViViendaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoViviendas_descripcion",
                table: "TipoViviendas",
                column: "descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zona_Localidades_sectorId",
                table: "Zona_Localidades",
                column: "sectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Zona_Localidades_zonaId",
                table: "Zona_Localidades",
                column: "zonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zonas_nombreZona",
                table: "Zonas",
                column: "nombreZona",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudad_Departamentos");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Pais_Departamentos");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "CorreoUsuarios");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropTable(
                name: "Jerarquias");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "TelefonoUsuarios");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Correos");

            migrationBuilder.DropTable(
                name: "TipoVivienda_Barrios");

            migrationBuilder.DropTable(
                name: "Telefonos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Ciudad_BarrioZonaLocalidades");

            migrationBuilder.DropTable(
                name: "TipoViviendas");

            migrationBuilder.DropTable(
                name: "Barri_ZonaLocalidades");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Barrios");

            migrationBuilder.DropTable(
                name: "Zona_Localidades");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Zonas");
        }
    }
}
