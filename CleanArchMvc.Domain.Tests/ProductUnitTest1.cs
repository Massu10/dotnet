using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Product With Valid State")]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Teste", "Description of Product.", 1000, 10, "c:/test");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With missing image and return Valid State")]
        public void CreateProduct_WithValidParametersMissingImage_ResultObjectValidState()
        {
            Action action = () => new Product(2, "Teste2", "Description of Product.", 1000, 10, "");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        public void CreateProduct_WithValidParametersNullImage_ResultObjectValidState()
        {
            Action action = () => new Product(3, "Teste3", "Description of Product.", 1000, 10, null);
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With missing name and return domain exception")]
        public void CreateProduct_MissingName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(2, "", "Description of Product.", 1000, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required.");
        }

        [Fact(DisplayName = "Create Product With short name and return domain exception")]
        public void CreateProduct_ShortName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(2, "Te", "Description of Product.", 1000, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product With null name and return domain exception")]
        public void CreateProduct_NullName_DomainExceptionInvalidName()
        {
            Action action = () => new Product(2, null, "Description of Product.", 1000, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With missing descrition and return domain exception")]
        public void CreateProduct_MissingDescrition_DomainExceptionInvalidName()
        {
            Action action = () => new Product(2, "Teste2", "", 1000, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description.Description is required.");
        }

        [Fact(DisplayName = "Create Product With short description and return domain exception")]
        public void CreateProduct_ShortDescription_DomainExceptionInvalidName()
        {
            Action action = () => new Product(2, "Teste2", "te", 1000, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product With null name and return domain exception")]
        public void CreateProduct_NullDescription_DomainExceptionInvalidName()
        {
            Action action = () => new Product(3, "Teste3", null, 1000, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Theory(DisplayName = "Create Product With negative price and return domain exception")]
        [InlineData(-100)]
        public void CreateProduct_NegativePrice_DomainExceptionInvalidName(int value)
        {
            Action action = () => new Product(3, "Teste3", "Description of Product.", value, 10, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price value.");
        }

        [Theory(DisplayName = "Create Product With negative stock and return domain exception")]
        [InlineData(-10)]
        public void CreateProduct_NegativeStock_DomainExceptionInvalidName(int value)
        {
            Action action = () => new Product(3, "Teste3", "Description of Product.", 1000, value, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock value.");
        }

        [Fact(DisplayName = "Create Product With to null image and return domain exception")]
        public void CreateProduct_NullImage_DomainExceptionInvalidName()
        {
            Action action = () => new Product(3, "Teste3", "Description of Product.", 1000, 10, null);
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create Product With to long image and return domain exception")]
        public void CreateProduct_LongImage_DomainExceptionInvalidName()
        {
            Action action = () => new Product(3, "Teste3", "Description of Product.", 1000, 10, "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretiumasd.");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        [Fact(DisplayName = "Create Product With to null image and return null exception")]
        public void CreateProduct_NullImage_NullExceptionInvalidName()
        {
            Action action = () => new Product(3, "Teste3", "Description of Product.", 1000, 10, null);
            action.Should()
                .NotThrow<NullReferenceException>();
        }
    }

}
