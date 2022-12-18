﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace World_of_Books_.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Windows;

    public partial class DB_WOB : DbContext
    {
        private static DB_WOB _context;
        public DB_WOB()
        : base("name=DB_WOB")
        {
        }

        private static bool CheckConnecting()
        {
            try
            {
                DB_WOB wob = new DB_WOB();
                wob.Database.Connection.Open();
                return true;
            }
            catch
            {
                MessageBox.Show("Отсутствует подключение к серверу.Проверьте подключение и повторите попытку позже!",
                "Ошибка подключения", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
        }

        public static DB_WOB GetContext()
        {
            if (!CheckConnecting())
            {
                Environment.Exit(0);
            }
            if (_context == null)
            {
                _context = new DB_WOB();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookImage> BookImage { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Cover> Cover { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<PublishingHouse> PublishingHouse { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserImage> UserImage { get; set; }
    }
}
