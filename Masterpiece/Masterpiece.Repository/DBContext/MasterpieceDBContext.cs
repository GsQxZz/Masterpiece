﻿using Masterpiece.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masterpiece.Repository.DBContext
{
    public class MasterpieceDBContext:DbContext
    {
        public virtual DbSet<Product> Product { get; set; }
        public MasterpieceDBContext() : base("MasterpieceDBContext")
        {
            Database.SetInitializer<MasterpieceDBContext>(null);
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //string assembleFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("Masterpiece.Data.DLL", "Masterpiece.Mapping.DLL").Replace("file:///", "");
            //Assembly asm = Assembly.LoadFile(assembleFileName);

            //var typesToRegister = asm.GetTypes()
            //.Where(type => !String.IsNullOrEmpty(type.Namespace))
            //.Where(type => type.BaseType != null
            //&& type.BaseType.IsGenericType
            //&& type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            //foreach (var type in typesToRegister)
            //{
            //    dynamic configurationInstance = Activator.CreateInstance(type);
            //    modelBuilder.Configurations.Add(configurationInstance);
            //}
            //base.OnModelCreating(modelBuilder);
        }
    }
}
