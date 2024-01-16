using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GarageGoopApp.Tests
{
    // Интерфейс для подключения к базе данных
    public interface IDatabaseConnector
    {
        void Open();
        void Close();
    }

    // Фейковый объект для тестирования
    public class FakeDatabaseConnector : IDatabaseConnector
    {
        public bool OpenCalled { get; private set; }
        public bool CloseCalled { get; private set; }
        public bool ThrowExceptionOnOpen { get; set; }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            OpenCalled = true;
            if (ThrowExceptionOnOpen)
            {
                throw new Exception("Симулированное исключение при открытии");
            }
        }

        
    }

    [TestClass]
    public class DatabaseConnectionTests
    {
        [TestMethod]
        public void OpenConnection_Success()
        {
            // Arrange
            var fakeDatabaseConnector = new FakeDatabaseConnector();

            // Act
            var result = DatabaseHelper.OpenConnection(fakeDatabaseConnector);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(fakeDatabaseConnector.OpenCalled);
        }

        [TestMethod]
        public void OpenConnection_Failure()
        {
            // Arrange
            var fakeDatabaseConnector = new FakeDatabaseConnector();
            fakeDatabaseConnector.ThrowExceptionOnOpen = true;

            // Act
            var result = DatabaseHelper.OpenConnection(fakeDatabaseConnector);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CloseConnection_Success()
        {
            // Arrange
            var fakeDatabaseConnector = new FakeDatabaseConnector();

            // Act
            DatabaseHelper.CloseConnection(fakeDatabaseConnector);

        }

        
        
        [TestMethod]
        public void OpenConnection_NullConnector()
        {
            // Arrange
            IDatabaseConnector fakeDatabaseConnector = null;

            // Act
            var result = DatabaseHelper.OpenConnection(fakeDatabaseConnector);

            // Assert
            Assert.IsFalse(result);
        }

    }

    public static class DatabaseHelper
    {
        public static bool OpenConnection(IDatabaseConnector connector)
        {
            try
            {
                connector.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CloseConnection(IDatabaseConnector connector)
        {
            try
            {
                connector.Close();
            }
            catch (Exception)
            {
                // Логирование или обработка исключения, если необходимо
            }
        }
    }
}
