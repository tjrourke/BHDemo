using System;
using System.Collections.Generic;
using BHDemo.Common.Dto;
using BHDemo.Repos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BHDemo.Repos.Test
{
    [TestClass]
    public class ReasonRepositoryTests
    {
        private Mock<IReasonRepository> fakeRepo;

        [TestInitialize]
        public void TestInitialize()
        {
            var dtos = GetReasonDtos();
            fakeRepo = new Mock<IReasonRepository>();
            fakeRepo.Setup(x => x.List()).Returns(dtos);
            fakeRepo.Setup(x => x.GetById(1)).Returns(dtos[0]);
            fakeRepo.Setup(x => x.GetById(2)).Returns(dtos[1]);
            fakeRepo.Setup(x => x.GetById(3)).Returns(dtos[2]);
        }

        [TestMethod]
        public void GetListTest()
        {
            var dtos = GetReasonDtos();
            var actual = fakeRepo.Object.List();
            Assert.AreSame(dtos, actual);
        }

        [TestMethod]
        public void GetItem1Test()
        {
            var dtos = GetReasonDtos();
            var actual = fakeRepo.Object.GetById(1);
            Assert.AreSame(dtos[0], actual);
        }

        [TestMethod]
        public void GetItem2Test()
        {
            var dtos = GetReasonDtos();
            var actual = fakeRepo.Object.GetById(2);
            Assert.AreSame(dtos[1], actual);
        }

        [TestMethod]
        public void GetItem3Test()
        {
            var dtos = GetReasonDtos();
            var actual = fakeRepo.Object.GetById(3);
            Assert.AreSame(dtos[2], actual);
        }

        private List<ReasonDto> GetReasonDtos()
        {
            return new List<ReasonDto>()
            {
                new ReasonDto {
                    Id = 1,
                    Name = null,
                    Text = "The challenge of contributing to a new application at the ground floor.",
                    Details = null,
                    CreatedDate = DateTime.Parse("2019-07-11T23:14:42.52"),
                    CreatedBy = "Tim Rourke",
                    EditedDate = DateTime.Parse("2019-07-11T23:14:42.52"),
                    EditedBy = "Tim Rourke"
                },
                new ReasonDto {
                    Id = 2,
                    Name = null,
                    Text = "Participating in building a new team.",
                    Details = null,
                    CreatedDate = DateTime.Parse("2019-07-11T23:14:42.52"),
                    CreatedBy = "Tim Rourke",
                    EditedDate = DateTime.Parse("2019-07-11T23:14:42.52"),
                    EditedBy = "Tim Rourke"
                },
                new ReasonDto {
                    Id = 3,
                    Name = null,
                    Text = "Family and Friends will recognize the name of the company without too much explanation.",
                    Details = null,
                    CreatedDate = DateTime.Parse("2019-07-11T23:14:42.52"),
                    CreatedBy = "Tim Rourke",
                    EditedDate = DateTime.Parse("2019-07-11T23:14:42.52"),
                    EditedBy = "Tim Rourke"
                }
            };
        }
    }
}
