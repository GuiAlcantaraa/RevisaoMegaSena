using FluentValidation;
using MegaSena.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaSena.Validations
{
    public class NumerosValidation: AbstractValidator<Numeros>
    {

        public NumerosValidation()
        {

            RuleFor(n => n.Numero1)

             .NotEmpty().WithMessage("O numero é obrigatorio, tente novamente")
             .NotNull().WithMessage(" Numero não informado, tente novamente")
             .LessThan(1).WithMessage("O numero tem que ser maior que 1")
             .GreaterThan(60).WithMessage("O numero não pode ser maior que 60")
             ;



            RuleFor(n => n.Numero2)

             .NotEmpty().WithMessage("O numero é obrigatorio, tente novamente")
             .NotNull().WithMessage(" Numero não informado, tente novamente")
             .LessThan(1).WithMessage("O numero tem que ser maior que 1")
             .GreaterThan(60).WithMessage("O numero não pode ser maior que 60")
             ;



            RuleFor(n => n.Numero3)

             .NotEmpty().WithMessage("O numero é obrigatorio, tente novamente")
             .NotNull().WithMessage(" Numero não informado, tente novamente")
             .LessThan(1).WithMessage("O numero tem que ser maior que 1")
             .GreaterThan(60).WithMessage("O numero não pode ser maior que 60")
             ;


            RuleFor(n => n.Numero4)

             .NotEmpty().WithMessage("O numero é obrigatorio, tente novamente")
             .NotNull().WithMessage(" Numero não informado, tente novamente")
             .LessThan(1).WithMessage("O numero tem que ser maior que 1")
             .GreaterThan(60).WithMessage("O numero não pode ser maior que 60")
             ;


            RuleFor(n => n.Numero5)

             .NotEmpty().WithMessage("O numero é obrigatorio, tente novamente")
             .NotNull().WithMessage(" Numero não informado, tente novamente")
             .LessThan(1).WithMessage("O numero tem que ser maior que 1")
             .GreaterThan(60).WithMessage("O numero não pode ser maior que 60")
             ;


            RuleFor(n => n.Numero6)

             .NotEmpty().WithMessage("O numero é obrigatorio, tente novamente")
             .NotNull().WithMessage(" Numero não informado, tente novamente")
             .LessThan(1).WithMessage("O numero tem que ser maior que 1")
             .GreaterThan(60).WithMessage("O numero não pode ser maior que 60")
             ;


        }



    }
}
