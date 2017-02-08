using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using VeiculoWeb.Entities.Models;

namespace VeiculoWeb.Core
{
    public class ClienteService
    {
        private DBService dbService = new DBService();

        public HttpStatusCode Create(Cliente cliente)
        {
            try
            {
                var conn = dbService.GetDatabase();

                var collection = conn.GetCollection<Cliente>("cliente");

                var count = conn.GetCollection<Cliente>("cliente").FindAll().ToList().Count();
                var clientId = count + 1;


                List<string> filesNames = new List<string>();
                if (cliente.uploadedFile != null)
                {
                    for (var i = 0; i < cliente.uploadedFile.Length; i++)
                    {
                        string filename = clientId + "_" + cliente.uploadedFile[i].FileName;
                        string uploadFilePathAndName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"Images\", filename);

                        cliente.uploadedFile[i].SaveAs(uploadFilePathAndName);

                        filesNames.Add(filename);
                    }
                }

                var entity = new Cliente()
                {
                    Id = clientId,
                    Nome = cliente.Nome,
                    CPF = cliente.CPF,
                    Renavam = cliente.Renavam,
                    Placa = cliente.Placa,
                    Imagens = filesNames
                };

                collection.Insert(entity);

                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar" + ex.Message);
            }
        }

        public List<Cliente> GetAll()
        {
            try
            {
                var conn = dbService.GetDatabase();

                var collection = conn.GetCollection<Cliente>("cliente").FindAll().ToList();
                return collection;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar" + ex.Message);
            }
        }

        public Cliente GetById(int id)
        {
            var conn = dbService.GetDatabase();

            var collection = conn.GetCollection<Cliente>("cliente").FindOneById(id);
            return collection;
        }

    }
}
