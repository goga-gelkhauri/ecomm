﻿var app = new Vue({
    el: '#app',
    data: {
        products: [],
        selectedProduct : null,
        newStock: {
            productId: 0,
            description: "Size",
            qty : 10
        }
    },
    mounted() {
        this.getStock();
    },
    methods: {
        getStock() {
            this.loading = true;
            axios.get('/stocks')
                .then(res => {
                    this.products = res.data;
                    console.log(this.products);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        selectProduct(product) {
            this.selectedProduct = product;
            this.newStock.productId = product.id;
        },
        updateStock() {
            this.loading = true;
            axios.put('/stocks', {
                stock: this.selectedProduct.stock.map(x => {
                    return {
                        id: x.id,
                        description: x.description,
                        qty: x.qty,
                        productId: this.selectedProduct.id
                    };

                })
            })
                .then(res => {
                   
                    console.log(this.products);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        deleteStock(id,index) {
            this.loading = true;
            axios.delete('/stocks/' + id)
                .then(res => {
                    this.selectedProduct.stock.splice(index,1);
                    console.log(this.products);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        addStock() {
            this.loading = true;
            axios.post('/stocks', this.newStock)
                .then(res => {
                    this.selectedProduct.stock.push(res.data); 
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
    }



});