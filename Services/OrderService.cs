using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using Microsoft.Extensions.Logging;
using PMApplication.Entities;
using PMApplication.Entities.PartAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Enums;
using PMApplication.Interfaces.RepositoryInterfaces;

namespace PMApplication.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        //private readonly IAsyncRepositoryLong<OrderItem> _orderItemRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IOrderPlanogramRepository _orderPlanogramRepository;
        private readonly IPlanogramService _planogramService;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IOrderRepository orderRepository, IMapper mapper, ILogger<OrderService> logger, IPlanogramService planogramService, IOrderPlanogramRepository orderPlanogramRepository, IOrderItemRepository orderItemRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _logger = logger;
            _planogramService = planogramService;
            _orderItemRepository = orderItemRepository;
            _orderPlanogramRepository = orderPlanogramRepository;
        }

        #region IOrderService Members

        public async Task<Order> GetOrder(long id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            return order;
        }

        public async Task<IReadOnlyList<Order>> GetOrders(OrderFilter filter)
        {
            var spec = new OrderSpecification(filter);
            var orders = await _orderRepository.ListAsync(spec);

            return orders;
        }

        public Task<IReadOnlyList<Order>> GetOpenOrdersByCountry(int countryId)
        {
            throw new NotImplementedException();
        }


        public Task<IReadOnlyList<OrderItem>> GetOrders(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<OrderInfo>> GetFilteredOrders(int brandId, int? page, int? pageSize, string sortBy, string sortOrder, string searchString,
            int? status, int? countryId, int? regionId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<OrderExport>> GetOrderExport(int id)
        {
            throw new NotImplementedException();
        }


        public Task<IReadOnlyList<SelectListItem>> GetOrderStatuses(int selected)
        {
            throw new NotImplementedException();
        }

        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrder()
        {
            throw new NotImplementedException();
        }

        public async Task<OrderItem> GetOrderItem(int id)
        {
            return await _orderItemRepository.GetByIdAsync(id);
        }

        public async Task<IReadOnlyList<OrderItem>> GetOrderItems(OrderItemFilter filter)
        {
            var spec = new OrderItemSpecification(filter);
            var orderItems = await _orderItemRepository.ListAsync(spec);
            
            return orderItems;
        }


        public async Task<IReadOnlyList<OrderItemInfo>> GetOrderItemInfos(long orderId)
        {
            try
            {
                var orderItems = await _orderItemRepository.GetOrderItems(orderId);
                return orderItems;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }


        public void CreateOrderItem(OrderItem OrderItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderItem(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrderItem()
        {
            throw new NotImplementedException();
        }

        public Task DeletePlanogram(int orderId, int planogramId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFullPlanogram(int orderId, int orderPlanogramId)
        {
            throw new NotImplementedException();
        }

        public async void AddPartsToOrder(int orderId, int planogramId, int quantity, string userId, string userName, bool isFullPlano)
        {
            try
            {
                var order = await _orderRepository.GetByIdAsync(orderId);
                var plano = await _planogramService.GetPlanogram(planogramId);


                var parts = isFullPlano
                    ? plano.PlanogramParts.Select(s => s.Part).ToList()
                    : plano.PlanogramParts
                        .Where(p => p.PartStatusId == (int)PlanoItemStatusEnum.NewModule)
                        .Where(p => p.ScratchPadId == null)
                        .Select(s => s.Part).ToList();

                if (isFullPlano)
                {
                    var shelfParts = plano.PlanogramShelves.Select(s => s.Part).ToList();
                    parts.AddRange(shelfParts);
                }




                if (!parts.Any())
                {
                    throw new Exception("No parts to add");
                }

                var orderPlanogram = new OrderPlanogram
                {
                    DateAdded = DateTime.Now,
                    IsFullPlano = isFullPlano,
                    OrderId = orderId,
                    PlanogramId = planogramId,
                    UserId = userId,
                    Username = userName
                };

                order.OrderPlanograms.Add(orderPlanogram);

                await _orderPlanogramRepository.AddAsync(orderPlanogram);
                foreach (var planogramPart in parts)
                {
                    var oi = new OrderItem
                    {
                        DateAdded = DateTime.Now,
                        OrderId = orderId,
                        PartId = planogramPart.Id,
                        PartName = planogramPart.Name,
                        PartNumber = planogramPart.PartNumber,
                        Quantity = quantity,
                        PlanogramId = planogramId,
                        InitialQuantity = quantity,
                        OrderPlanogramId = orderPlanogram.Id
                    };
                    order.OrderItems.Add(oi);
                    await _orderItemRepository.AddAsync(oi);
                    await _orderRepository.UpdateAsync(order);
                    //not sure we need to do both
                }
                
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);


            }
        }
        #endregion


    }
}
