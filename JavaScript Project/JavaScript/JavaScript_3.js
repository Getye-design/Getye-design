// Select the element with the data attribute
const productElement = document.getElementById('product');

// Retrieve data attributes
const productId = productElement.getAttribute('data-product-id');
const productName = productElement.getAttribute('data-product-name');

// Display the product information
productElement.textContent = `Product ID: ${productId}, Product Name: ${productName}`;
