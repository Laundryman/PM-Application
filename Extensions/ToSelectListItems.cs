using PMApplication.Entities.ClusterAggregate;
using PMApplication.Entities.CountriesAggregate;
using PMApplication.Entities.JobsAggregate;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.PlanogramAggregate;
using PMApplication.Entities.StandAggregate;
using PMApplication.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMApplication.Entities.ProductAggregate;

namespace PMApplication.Extensions
{
    public static class ToSelectListItemsHelper
    {
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Category> categories, int selectedId)
        {
            return

                categories.OrderBy(category => category.Name)
                      .Select(category =>
                          new SelectListItem
                          {
                              Selected = (category.Id == selectedId),
                              Text = category.Name,
                              Value = category.Id.ToString()
                          });
        }
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Product> products, int selectedId)
        {
            return

                products.OrderBy(product => product.Name)
                      .Select(product =>
                          new SelectListItem
                          {
                              Selected = (product.Id == selectedId),
                              Text = product.Name,
                              Value = product.Id.ToString()
                          });
        }
        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Country> countries, int selectedId)
        {
            return

                countries.OrderBy(country => country.Name)
                      .Select(country =>
                          new SelectListItem
                          {
                              Selected = (country.Id == selectedId),
                              Text = country.Name,
                              Value = country.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Region> regions, int selectedId)
        {
            return

                regions.OrderBy(region => region.Name)
                      .Select(region =>
                          new SelectListItem
                          {
                              Selected = (region.Id == selectedId),
                              Text = region.Name,
                              Value = region.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Brand> brands, int selectedId)
        {
            return

                brands.OrderBy(brand => brand.Name)
                      .Select(brand =>
                          new SelectListItem
                          {
                              Selected = (brand.Id == selectedId),
                              Text = brand.Name,
                              Value = brand.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<PartType> partTypes, int selectedId)
        {
            return

                partTypes.OrderBy(partType => partType.Name)
                      .Select(partType =>
                          new SelectListItem
                          {
                              Selected = (partType.Id == selectedId),
                              Text = partType.Name,
                              Value = partType.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Part> parts, int selectedId)
        {
            return

                parts.OrderBy(part => part.Name)
                      .Select(part =>
                          new SelectListItem
                          {
                              Selected = (part.Id == selectedId),
                              Text = part.Name,
                              Value = part.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Shade> shades, int selectedId)
        {
            return

                shades.OrderBy(shade => shade.ShadeNumber)
                      .Select(shade =>
                          new SelectListItem
                          {
                              Selected = (shade.Id == selectedId),
                              Text = shade.ShadeNumber,
                              Value = shade.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<StandType> standTypes, int selectedId)
        {
            return

                standTypes.OrderBy(standType => standType.Name)
                      .Select(standType =>
                          new SelectListItem
                          {
                              Selected = (standType.Id == selectedId),
                              Text = standType.Name,
                              Value = standType.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
        this IEnumerable<StandType> standTypes, IEnumerable<StandType> selectedTypes)
        {
            StandTypeComparer comparer = new StandTypeComparer();
            return

                standTypes.OrderBy(standType => standType.Name)
                      .Select(standType =>
                          new SelectListItem
                          {
                              Selected = (selectedTypes.Contains(standType, comparer)),
                              Text = standType.Name,
                              Value = standType.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Stand> stands, int selectedId)
        {
            return

                stands.OrderBy(stand => stand.Name)
                      .Select(s =>
                          new SelectListItem
                          {
                              Selected = (s.Id == selectedId),
                              Text = s.Name,
                              Value = s.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Planogram> planograms, int selectedId)
        {
            return

                planograms.OrderBy(planogram => planogram.Name)
                      .Select(p =>
                          new SelectListItem
                          {
                              Selected = (p.Id == selectedId),
                              Text = p.Name,
                              Value = p.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Cluster> clusters, int selectedId)
        {
            return

                clusters.OrderBy(cluster => cluster.Name)
                      .Select(p =>
                          new SelectListItem
                          {
                              Selected = (p.Id == selectedId),
                              Text = p.Name,
                              Value = p.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<string> roles, string selected)
        {
            return

                roles.Select(r =>
                          new SelectListItem
                          {
                              Selected = (r == selected),
                              Text = r,
                              Value = r
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<JobFolder> jobFolders, int selectedId)
        {
            return

                jobFolders.Select(f =>
                          new SelectListItem
                          {
                              Selected = (f.Id == selectedId),
                              Text = f.Name,
                              Value = f.Id.ToString()
                          });
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
            this IEnumerable<Role> roles, string selectedIds)
        {
            var selectedRoles = selectedIds.Split(',');
            return

                roles.Select(f =>
                    new SelectListItem
                    {
                        Selected = (selectedRoles.Contains(f.RoleId.ToString())),
                        Text = f.RoleName,
                        Value = f.RoleId.ToString()
                    });
        }

    }
}
