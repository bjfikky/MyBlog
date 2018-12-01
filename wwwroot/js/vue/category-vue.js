let modal = Vue.component('modal', {
    template: '#modal-template',

    data: function() {
        return {
            name: ''
        }
    },

    props: ['getCategories'],

    methods: {
        addCategory() {
            axios.post('/api/categories', {
                name: this.name
            }).then(() => {
                this.$parent.getCategories()
            })
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
            axios.get('/api/categories').then(response => {
                this.showModal = false
                this.categories = response.data
            })
        }
    }
})
