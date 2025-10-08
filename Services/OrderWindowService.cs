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
using PMApplication.Interfaces.RepositoryInterfaces;
using PMApplication.Interfaces.ServiceInterfaces;
using PMApplication.Specifications;
using PMApplication.Specifications.Filters;

namespace PMApplication.Services
{
    public class OrderWindowService : IOrderWindowService
    {
        private readonly IOrderRepository _orderRepository;
        //private readonly IAsyncRepositoryLong<OrderItem> _orderItemRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IOrderWindowRepository _orderWindowRepository;
        private readonly IOrderPlanogramRepository _orderPlanogramRepository;
        private readonly IPlanogramService _planogramService;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderService> _logger;

        public OrderWindowService(IOrderRepository orderRepository, IOrderItemRepository orderItemRepository, IOrderPlanogramRepository orderPlanogramRepository, IPlanogramService planogramService, IMapper mapper, ILogger<OrderService> logger, IOrderWindowRepository orderWindowRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
            _orderPlanogramRepository = orderPlanogramRepository;
            _planogramService = planogramService;
            _mapper = mapper;
            _logger = logger;
            _orderWindowRepository = orderWindowRepository;
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
