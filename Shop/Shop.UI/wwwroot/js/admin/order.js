var app = new Vue({
    el: '#app',
    data: {
        orders: [],
        
        
    },
    mounted() {
        this.getOrder();
    },
    methods: {
        getOrder() {
            this.loading = true;
            axios.get('/orders')
                .then(res => {
                    this.orders = res.data;
                    console.log(this.orders);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        deleteOrder(id, index) {
            this.loading = true;
            axios.delete('/orders/' + id)
                .then(res => {
                    this.orders.splice(index, 1);
                    console.log(this.orders);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        
    }



});