contactsApp.factory('contactsService', ($http) => {
    return {
        loadAll() {
            return $http.get("/Contact/GetAll");
        },

        save(contacts) {
            $http.post("/Contact/Save", contacts);
        }
    }
})