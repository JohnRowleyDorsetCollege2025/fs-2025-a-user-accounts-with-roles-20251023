using System.Linq;
using Xunit;
using fs_user_accounts.Data;

namespace AppTesting.Tests
{
    public class MockDataTests
    {
        [Fact]
        public void Patients_Returns_Default_50()
        {
            var patients = MockData.Patients();
            Assert.NotNull(patients);
            Assert.Equal(50, patients.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(100)]
        public void Patients_Returns_Requested_Number(int count)
        {
            var patients = MockData.Patients(count);
            Assert.NotNull(patients);
            Assert.Equal(count, patients.Count);
        }

        [Fact]
        public void Patients_Have_NonEmpty_Properties_And_Valid_Email()
        {
            var patients = MockData.Patients(20);
            foreach (var p in patients)
            {
                Assert.False(string.IsNullOrWhiteSpace(p.Id));
                Assert.False(string.IsNullOrWhiteSpace(p.FirstName));
                Assert.False(string.IsNullOrWhiteSpace(p.LastName));
                Assert.False(string.IsNullOrWhiteSpace(p.Email));
                Assert.Contains("@", p.Email);
            }
        }

        [Fact]
        public void Patients_Ids_Are_Unique()
        {
            var patients = MockData.Patients(200);
            var distinctIds = patients.Select(p => p.Id).Distinct().Count();
            Assert.Equal(patients.Count, distinctIds);
        }
    }
}