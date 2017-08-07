using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using MusicRoadmap.Model;

namespace MusicRoadmap.Repositories
{
    public class MusicRepository
    {
        private SQLiteConnection _connection;

        public MusicRepository(SQLiteConnection connection)
        {
                

            _connection = connection;
            _connection.CreateTable<Tag>();
            //_connection.CreateTable<Tags>();
            //_connection.CreateTable<Bio>();
            //_connection.CreateTable<ArtistDetails>();
        }

        public Tag Get(int id)
        {
            var query = from ad in _connection.Table<Tag>() where ad.id == id select ad;
            return query.FirstOrDefault();
        }

        public void Create(Tag car)
        {
            _connection.Insert(car);
            _connection.Commit();
        }

    }
}
