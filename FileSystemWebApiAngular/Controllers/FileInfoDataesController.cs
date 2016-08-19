using FileSystemWebApiAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FileSystemWebApiAngular.Controllers
{
    public class FileInfoDataesController : ApiController
    {
        public IEnumerable<FileInfoData> Get()
        {
            FileInfoDataModel fidm = new FileInfoDataModel();
            return fidm.findAll().AsEnumerable();
        }

        public IEnumerable<FileInfoData> Get(string id)
        {
            FileInfoDataModel fidm = new FileInfoDataModel();
            return fidm.findAll(id).AsEnumerable();
        }

        public IEnumerable<FileInfoData> Post(string id)
        {
            FileInfoDataModel fidm = new FileInfoDataModel();
            return fidm.findAllBack(id).AsEnumerable();
        }
    }
}
