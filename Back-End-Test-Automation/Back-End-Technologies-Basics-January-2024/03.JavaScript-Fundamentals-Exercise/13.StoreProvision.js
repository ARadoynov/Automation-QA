function solve(firstArr, secondArr) {

    function addProduct(inputArr) {

        let result = [];
        for (let i = 0; i < inputArr.length; i += 2) {
            let productName = inputArr[i];
            let productQuantity = Number(inputArr[i + 1]);

            result.push({ productName, productQuantity });
        }

        return result;
    }

    function uniteAndSumStock(stockArr, ordersArr) {

        ordersArr.forEach(order => {
            let orderProduct = order.productName;
            let orderQuantity = order.productQuantity;

            let stockProduct = stockArr.find(product => product.productName === orderProduct);

            if (stockProduct) {
                // If the product exists in stock, update the quantity
                stockProduct.productQuantity += orderQuantity;
            } else {
                // If the product doesn't exist, add it to stock
                stockArr.push({ productName: orderProduct, productQuantity: orderQuantity });
            }
        });
    }

    function printProducts(stockArr) {
        stockArr.forEach(({ productName, productQuantity }) => {
            console.log(`${productName} -> ${productQuantity}`);
        });
    }

    let stockArr = addProduct(firstArr);
    let ordersArr = addProduct(secondArr);
    
    uniteAndSumStock(stockArr, ordersArr);
    printProducts(stockArr);
}

solve(
    [
        'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
    ],
    [
        'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]
);