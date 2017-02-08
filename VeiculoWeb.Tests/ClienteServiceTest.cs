using Microsoft.VisualStudio.TestTools.UnitTesting;
using VeiculoWeb.Core;
using VeiculoWeb.Entities.Models;
using FluentAssertions;

namespace VeiculoWeb.Tests
{
    [TestClass]
    public class ClienteServiceTest
    {
        private static ClienteService _clienteService = new ClienteService();

        [TestMethod]
        public void Create()
        {
            var cliente = new Entities.Models.Cliente()
            {
                Nome = "Teste",
                CPF = "123.123.123-03",
                Placa = "EGD-8181",
                Renavam = "H24L24O24",
                Bloqueado = false,
                uploadedFile = null
            };

            var createCliente = _clienteService.Create(cliente);

            Assert.AreEqual("OK", createCliente.ToString());
        }

        [TestMethod]
        public void GetAll()
        {
            var cliente = _clienteService.GetAll();
            cliente.Should().NotBeNull();
        }

        [TestMethod]
        public void GetById()
        {
            var cliente = _clienteService.GetById(1);
            cliente.Should().NotBeNull();
        }
    }
}
