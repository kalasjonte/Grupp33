using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELS;

namespace DAL
{
    public class MediaRepository : IMediaRepository<Media>
    {
        SerializerXml serializerXml;
        List<Podcast> mediaList;

        //Generella CRUDO metoder för repositorie patterns:
        public void Create(Podcast entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int index)
        {
            throw new NotImplementedException();
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Podcast entity)
        {
            throw new NotImplementedException();
        }

        public List<Podcast> GetAll()
        {
            throw new NotImplementedException();
        }

        //Specifika för IMediaRepositories:
        public Podcast GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByType(string type)
        {
            throw new NotImplementedException();
        }

        public Podcast GetByUrl(string url)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Podcast> SortDesending()
        {
            throw new NotImplementedException();
        }

        Media IMediaRepository<Media>.GetByName(string name)
        {
            throw new NotImplementedException();
        }

        Media IMediaRepository<Media>.GetByUrl(string url)
        {
            throw new NotImplementedException();
        }

        Media IMediaRepository<Media>.GetByType(string type)
        {
            throw new NotImplementedException();
        }

        public void Create(Media entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int index, Media entity)
        {
            throw new NotImplementedException();
        }

        List<Media> IRepository<Media>.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Media> IRepository<Media>.SortDesending()
        {
            throw new NotImplementedException();
        }
    }
}
