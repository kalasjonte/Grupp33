using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELS;

namespace DAL
{
    class MediaRepository : IMediaRepository<Media>
    {
        SerializerXml serializerXml;
        List<Media> mediaList;

        //Generella metoder för repositorie patterns:
        public void Create(Media entity)
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

        public void Update(int index, Media entity)
        {
            throw new NotImplementedException();
        }

        public List<Media> GetAll()
        {
            throw new NotImplementedException();
        }

        //Specifika för IMediaRepositories:
        public Media GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Media GetByType(string type)
        {
            throw new NotImplementedException();
        }

        public Media GetByUrl(string url)
        {
            throw new NotImplementedException();
        }
    }
}
