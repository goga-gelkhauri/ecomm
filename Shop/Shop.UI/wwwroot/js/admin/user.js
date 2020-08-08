var app = new Vue({
    el: '#app',
    data: {
        username: '',


    },
    mounted() {
        
    },
    methods: {
        createUser() {
            this.loading = true;
            axios.post('/users', { username: this.username })
                .then(res => {
                    console.log(this.orders);
                }).catch(err => {
                    console.log(err);
                });
        }

    }



});