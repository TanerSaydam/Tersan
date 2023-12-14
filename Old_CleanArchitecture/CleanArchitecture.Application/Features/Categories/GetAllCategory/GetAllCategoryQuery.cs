using CleanArchitecture.Domain.Entities;
using ErrorOr;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Categories.GetAllCategory;
public sealed record GetAllCategoryQuery(): IRequest<ErrorOr<List<Category>>>;
