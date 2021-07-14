contactsApp.factory('contactsService', ($http) => {
    return {
        loadAll() {
            return [
                {
                    surname: 'Иванов',
                    name: 'Иван',
                    patronymic: 'Иванович',
                    phoneNumber: '379-0861',
                    email: 'ivanov@mail.ru'
                }, 
                {
                    surname: 'Петров',
                    name: 'Петр',
                    patronymic: 'Петрович',
                    phoneNumber: '977-2232',
                    email: 'petrov@mail.ru'
                },
                {
                    surname: 'Сидоров',
                    name: 'Александр',
                    patronymic: 'Александрович',
                    phoneNumber: '977-2237',
                    email: 'sidorov@mail.ru'
                },
            ];
        },

        loadFromFile(filePath) {
            return $http.get(filePath);
        }
    }
})