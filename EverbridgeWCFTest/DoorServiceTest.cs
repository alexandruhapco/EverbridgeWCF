using EverbridgeWCF;
using EverbridgeWCF.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace EverbridgeWCFTest {
    [TestClass]
    public class DoorServiceTest {

        private List<Door> doorList;

        [TestInitialize]
        public void init() {
            doorList = new List<Door>() {
                new Door(1, "first TestDoor",  isOpen:true, isLocked:false),
                new Door(2, "second TestDoor",  isOpen:false, isLocked:true),
                new Door(3, "third TestDoor", isOpen:false, isLocked:false)
            };
        }

        [TestMethod]
        public void openDoorTest() {
            var mock = new Mock<IDoorDAO>();
            mock.SetupSequence(x => x.getDoor(It.IsAny<long>())).Returns(doorList[0]).Returns(doorList[1]).Returns(doorList[2]);
            var service = new DoorService(mock.Object);
            bool result;
            result = service.openDoor(0);
            Assert.IsTrue(result);
            result = service.openDoor(0);
            Assert.IsFalse(result);
            result = service.openDoor(0);
            Assert.IsTrue(result);
        }

    }
}
