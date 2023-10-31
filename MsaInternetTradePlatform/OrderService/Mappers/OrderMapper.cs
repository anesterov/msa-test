using OrderService.Models.Contract;
using OrderService.Models.Store;

namespace OrderService.Mappers
{
    public static class OrderMapper
    {
        public static OrderPosition MapFromStore(OrderPositionEntity storeObj)
        {
            if (storeObj == null)
            {
                return null;
            }

            return new OrderPosition
            {
                ItemId = storeObj.ItemId,
                ItemPrice = storeObj.ItemPrice,
                ItemQuantity = storeObj.ItemQuantity,
            };
        }

        public static OrderStatus MapFromStore(OrderStatusEntity storeObj)
        {
            if (storeObj == null)
            {
                return null;
            }

            return new OrderStatus
            {
                Date = storeObj.Date,
                Description = storeObj.Description,
                Id = storeObj.Id,
                Name = storeObj.Name,
            };
        }

        public static Order MapFromStore(OrderEntity storeObj)
        {
            if (storeObj == null)
            {
                return null;
            }

            return new Order
            {
                Id = storeObj.Id,
                ClientId = storeObj.ClientId,
                OrderStartDate = storeObj.OrderStartDate,
            };
        }

        public static OrderPositionEntity MapToStore(OrderPosition obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new OrderPositionEntity
            {
                ItemId = obj.ItemId,
                ItemPrice = obj.ItemPrice,
                ItemQuantity = obj.ItemQuantity,
            };
        }

        public static OrderStatusEntity MapToStore(OrderStatus obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new OrderStatusEntity
            {
                Date = obj.Date,
                Description = obj.Description,
                Id = obj.Id,
                Name = obj.Name,
            };
        }

        public static OrderEntity MapToStore(Order obj)
        {
            if (obj == null)
            {
                return null;
            }

            return new OrderEntity
            {
                Id = obj.Id,
                ClientId = obj.ClientId,
                OrderStartDate = obj.OrderStartDate,
            };
        }
    }
}
