using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModuloAdministrador.Models
{
    public partial class InventarioContext : DbContext
    {
        public InventarioContext()
        {
        }

        public InventarioContext(DbContextOptions<InventarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DetallesFactura> DetallesFacturas { get; set; } = null!;
        public virtual DbSet<DetallesGuia> DetallesGuias { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Guia> Guias { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<ProductosProveedor> ProductosProveedors { get; set; } = null!;
        public virtual DbSet<Proveedore> Proveedores { get; set; } = null!;
        public virtual DbSet<Solicitude> Solicitudes { get; set; } = null!;
        public virtual DbSet<Tarea> Tareas { get; set; } = null!;
        public virtual DbSet<Trabajadore> Trabajadores { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetallesFactura>(entity =>
            {
                entity.HasKey(e => e.IdFacturasDetallePk)
                    .HasName("PK__Detalles__CAFDE2FD9C7FEF96");

                entity.Property(e => e.IdFacturasDetallePk).HasColumnName("Id_FacturasDetallePK");

                entity.Property(e => e.IdFacturasFk).HasColumnName("Id_FacturasFK");

                entity.HasOne(d => d.IdFacturasFkNavigation)
                    .WithMany(p => p.DetallesFacturas)
                    .HasForeignKey(d => d.IdFacturasFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetallesF__Id_Fa__5535A963");
            });

            modelBuilder.Entity<DetallesGuia>(entity =>
            {
                entity.HasKey(e => e.IdGuiaDetalle)
                    .HasName("PK__Detalles__2FAB41F1E2B0567C");

                entity.Property(e => e.IdGuiaDetalle).HasColumnName("Id_GuiaDetalle");

                entity.Property(e => e.IdGuiaFk).HasColumnName("Id_GuiaFK");

                entity.HasOne(d => d.IdGuiaFkNavigation)
                    .WithMany(p => p.DetallesGuia)
                    .HasForeignKey(d => d.IdGuiaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetallesG__Id_Gu__52593CB8");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.IdFacturasPk)
                    .HasName("PK__Facturas__4101C5B601FF3031");

                entity.Property(e => e.IdFacturasPk).HasColumnName("id_FacturasPK");

                entity.Property(e => e.DireccionDestino)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("direccion_destino");

                entity.Property(e => e.DireccionEmpresaOrigen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("direccion_empresa_origen");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("date")
                    .HasColumnName("fecha_factura");

                entity.Property(e => e.NombreEmpresaDestino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_empresa_destino");

                entity.Property(e => e.NombreEmpresaOrigen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_empresa_origen");

                entity.Property(e => e.NumeroFactura)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numero_factura");

                entity.Property(e => e.TelefonoEmpresaDestino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono_empresa_destino");

                entity.Property(e => e.TelefonoEmpresaOrigen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono_empresa_origen");
            });

            modelBuilder.Entity<Guia>(entity =>
            {
                entity.HasKey(e => e.IdGuiaPk)
                    .HasName("PK__Guias__BAB4B57754E3C803");

                entity.Property(e => e.IdGuiaPk).HasColumnName("id_GuiaPK");

                entity.Property(e => e.DireccionDestino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("direccion_destino");

                entity.Property(e => e.DireccionEmpresaOrigen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("direccion_empresa_origen");

                entity.Property(e => e.FechaGuia)
                    .HasColumnType("date")
                    .HasColumnName("fecha_guia");

                entity.Property(e => e.NombreEmpresaDestino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_empresa_destino");

                entity.Property(e => e.NombreEmpresaOrigen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_empresa_origen");

                entity.Property(e => e.NumeroGuia).HasColumnName("numero_guia");

                entity.Property(e => e.TelefonoEmpresaDestino)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono_empresa_destino");

                entity.Property(e => e.TelefonoEmpresaOrigen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono_empresa_origen");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProductoPk)
                    .HasName("PK__Producto__0E4225BC47477333");

                entity.Property(e => e.IdProductoPk).HasColumnName("id_productoPK");

                entity.Property(e => e.GramajeProducto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gramaje_producto");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_producto");

                entity.Property(e => e.StockProducto).HasColumnName("stock_producto");
            });

            modelBuilder.Entity<ProductosProveedor>(entity =>
            {
                entity.HasKey(e => e.IdProductoProveedorPk)
                    .HasName("PK__Producto__3B5D1AA79B01484B");

                entity.ToTable("Productos_proveedor");

                entity.Property(e => e.IdProductoProveedorPk).HasColumnName("id_producto_proveedorPK");

                entity.Property(e => e.IdProductoFk).HasColumnName("id_productoFK");

                entity.Property(e => e.IdProveedorFk).HasColumnName("id_proveedorFK");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdProductoFkNavigation)
                    .WithMany(p => p.ProductosProveedors)
                    .HasForeignKey(d => d.IdProductoFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__id_pr__4E88ABD4");

                entity.HasOne(d => d.IdProveedorFkNavigation)
                    .WithMany(p => p.ProductosProveedors)
                    .HasForeignKey(d => d.IdProveedorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Productos__id_pr__4F7CD00D");
            });

            modelBuilder.Entity<Proveedore>(entity =>
            {
                entity.HasKey(e => e.IdProveedorPk)
                    .HasName("PK__Proveedo__F6E93D8D0BB83A2D");

                entity.Property(e => e.IdProveedorPk).HasColumnName("id_proveedorPK");

                entity.Property(e => e.DireccionProveedor)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("direccion_proveedor");

                entity.Property(e => e.EmailProveedor)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("email_proveedor");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.GiroProvedor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("giro_provedor");

                entity.Property(e => e.NombreProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_proveedor");

                entity.Property(e => e.RutProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rut_proveedor");

                entity.Property(e => e.TelefonoProveedor)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("telefono_proveedor");
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudPk)
                    .HasName("PK__Solicitu__356E60354CE628E9");

                entity.Property(e => e.IdSolicitudPk).HasColumnName("id_solicitudPK");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.EstadoAprobacion).HasColumnName("estado_aprobacion");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnType("date")
                    .HasColumnName("fecha_solicitud");

                entity.Property(e => e.IdProductoFk).HasColumnName("id_productoFK");

                entity.Property(e => e.IdTrabajadorFk).HasColumnName("id_trabajadorFK");

                entity.Property(e => e.IdUsuarioFk).HasColumnName("id_usuarioFK");

                entity.Property(e => e.TipoSolicitud)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipo_solicitud");

                entity.HasOne(d => d.IdProductoFkNavigation)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.IdProductoFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__id_pr__48CFD27E");

                entity.HasOne(d => d.IdTrabajadorFkNavigation)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.IdTrabajadorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__id_tr__49C3F6B7");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Solicitudes)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__id_us__4AB81AF0");
            });

            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.HasKey(e => e.IdTareasPk)
                    .HasName("PK__Tareas__74A605B559ACB009");

                entity.Property(e => e.IdTareasPk).HasColumnName("id_tareasPK");

                entity.Property(e => e.EstadoTarea).HasColumnName("estado_tarea");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_asignacion");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.FechaFinalizacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_finalizacion");

                entity.Property(e => e.IdTrabajadorFk).HasColumnName("id_trabajadorFK");

                entity.Property(e => e.IdUsuarioFk).HasColumnName("id_usuarioFK");

                entity.Property(e => e.Prioridad)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("prioridad");

                entity.Property(e => e.TipoTarea)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipo_tarea");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .HasConstraintName("FK__Tareas__id_usuar__45F365D3");

                entity.HasOne(d => d.IdUsuarioFk1)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .HasConstraintName("FK__Tareas__id_usuar__44FF419A");
            });

            modelBuilder.Entity<Trabajadore>(entity =>
            {
                entity.HasKey(e => e.IdTrabajadorPk)
                    .HasName("PK__Trabajad__7D4E6DA8EE5AA3F0");

                entity.Property(e => e.IdTrabajadorPk).HasColumnName("id_trabajadorPK");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("apellido_materno");

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("apellido_paterno");

                entity.Property(e => e.Cargo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cargo");

                entity.Property(e => e.Celular)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdUsuarioFk).HasColumnName("id_usuarioFK");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdUsuarioFkNavigation)
                    .WithMany(p => p.Trabajadores)
                    .HasForeignKey(d => d.IdUsuarioFk)
                    .HasConstraintName("FK__Trabajado__id_us__4222D4EF");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuarioPk)
                    .HasName("PK__Usuarios__A318AD96228D8535");

                entity.Property(e => e.IdUsuarioPk).HasColumnName("id_usuarioPK");

                entity.Property(e => e.ContraseniaUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contrasenia_usuario");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nombre_usuario");

                entity.Property(e => e.TipoUsuario)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tipo_usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
