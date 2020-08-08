Vue.component('product-manager', {
    template: ` <div v-if="!editing">
                    <button @click="newProduct()" class="button is-success">Create Products</button>

                    <table class="table">
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Value</th>
                            <th>Action</th>
                        </tr>
                        <tr v-for="(product,index) in products">
                            <td>{{product.id}}</td>
                            <td>{{product.name}}</td>
                            <td>{{product.value}}</td>
                            <td>
                                <a @click="editProduct(product.id,index)" class="button is-warning">Edit</a>
                                <a @click="deleteProduct(product.id,index)" class="button is-danger">Delete</a>
                            </td>
                        </tr>
                    </table>

                </div>


                <div v-else>
                    <div class="field">
                        <div class="contorl">
                            <label>Product Name</label>
                            <input class="input" v-model="productModel.name">
                        </div>
                    </div>
                    <div class="field">
                        <div class="contorl">
                            <label>Product Description</label>
                            <input class="input" v-model="productModel.description">
                        </div>
                    </div>
                    <div class="field">
                        <div class="contorl">
                            <label>Product Value</label>
                            <input class="input" v-model="productModel.value" type="number">
                        </div>
                    </div>

                    
                    <button @click="createProduct()" class="button is-success" v-if="!productModel.id">Create Products</button>
                    <button @click="updateProduct()" class="button is-warning" v-else>Update Products</button>
                    <button @click="cancel()" class="button is-primary"  v-if="productModel.id">Cancel</button>
                </div>`,
    data() {
        return {
            editing: false,
            loading: false,
            products: [],
            productModel: {
                id: 0,
                name: "Produts name",
                description: "products description",
                value: 1.99
            },
            objectIndex: 0,
        }
        
    },
    mounted() {
        this.getProducts();
    },
    methods: {
        getProduct(id) {
            this.loading = true;
            axios.get('/products/' + id)
                .then(res => {
                    var product = res.data;
                    this.productModel = {
                        id: product.id,
                        name: product.name,
                        description: product.description,
                        value: product.value
                    };
                    console.log(res);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        getProducts() {
            this.loading = true;
            axios.get('/products')
                .then(res => {
                    this.products = res.data;
                    console.log(res);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },
        createProduct() {
            this.loading = true;
            axios.post('/products', this.productModel)
                .then(res => {
                    this.products.push(res.data);
                    console.log(res);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        updateProduct() {
            this.loading = true;
            axios.put('/products', this.productModel)
                .then(res => {
                    this.products.splice(this.objectIndex, 1, res.data);
                    console.log(res);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },
        calcel() {
            this.editing = false;
        },
        newProduct() {
            this.editing = true
            this.productModel.id = 0;
            this.productModel.value = parseFloat(this.productModel.value);
        },
        editProduct(id, index) {

            this.objectIndex = index;
            this.getProduct(id);
            this.editing = true;
        },
        deleteProduct(id, index) {
            this.loading = true;
            axios.delete('/products/' + id)
                .then(res => {
                    this.products.splice(index, 1);
                    console.log(res);
                }).catch(err => {
                    console.log(err);
                }).then(() => {
                    this.loading = false;
                });
        },

    }


});