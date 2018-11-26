let modal = Vue.component('modal', {
    template: '#modal-template',

    props: ['test'],

    methods: {
        addCategory() {
            this.$parent.categories.push({
                id : 6, name : 'Swift'
            })
            this.$parent.test()
        }
    }
})

new Vue ({
    el: '#category',

    components: {modal: modal},

    data: {
        showModal: false,
        
        categories: []
    },

    mounted() {
        this.getCategories()
    },

    methods: {
        getCategories() {
            let categories = axios.get('/api/categories').then(response => {
                this.categories = response.data
            })
        }
    }
    
})
