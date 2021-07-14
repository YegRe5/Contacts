contactsApp.controller("contactsController", function ($scope, contactsService) {
    $scope.contactsFilePath = '123';

    $scope.contacts = contactsService.loadAll();

    $scope.loadFromFile = () => {
        contactsService.loadFromFile($scope.contactsFilePath)
            .then(
                (response) => {
                    $scope.contacts = response.data;
            }, () => {
                alert("Не удалось загрузить контакты");
            });
    }

    $scope.removeContact = (contact) => {
        const index = $scope.contacts.indexOf(contact);
        $scope.contacts.splice(index, 1);
    }

    $scope.addContact = () => {
        const contact = {
            surname: "Фамилия",
            name: "Имя",
            patronymic: "Отчество",
            phoneNumber: "Телефон",
            email: "Адрес электронной почты"
        }

        $scope.contacts.push(contact);
    }
})