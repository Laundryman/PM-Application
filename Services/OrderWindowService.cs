using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Graph.Privacy;
using PMApplication.Entities.OrderAggregate;
using PMApplication.Interfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class OrderWindowService : IOrderWindowService
    {
        private readonly IAsyncRepositoryLong<Order> _orderRepository;
        //private readonly IAsyncRepositoryLong<OrderItem> _orderItemRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IAsyncRepository<OrderWindow> _orderWindowRepository;
        private readonly IAsyncRepository<OrderPlanogram> _orderPlanogramRepository;
        private readonly IPlanogramService _planogramService;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderService> _logger;

        public OrderWindowService(IAsyncRepositoryLong<Order> orderRepository, IOrderItemRepository orderItemRepository, IAsyncRepository<OrderPlanogram> orderPlanogramRepository, IPlanogramService planogramService, IMapper mapper, ILogger<OrderService> logger)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _orderPlanogramRepository = orderPlanogramRepository;
            _planogramService = planogramService;
            _mapper = mapper;
            _logger = logger;
        }


        public async Task<IReadOnlyList<OrderWindow>> GetOrderWindows(OrderWindowFilter filter)
        {
            var spec = new OrderWindowSpecification(filter);
            var orderWindows = await _orderWindowRepository.ListAsync(spec);
            return orderWindows;
        }

        public Task<IReadOnlyCollection<OrderWindow>> GetOrderWindowCalendar(int brandId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderWindow> GetOrderWindow(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateOrderWindow(OrderWindow orderWindow)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderWindow(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrderWindow()
        {
            throw new NotImplementedException();
        }

    }
}
