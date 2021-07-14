contactsApp.controller("contactsController", function ($scope, contactsService) {
    $scope.selectedContactIndex = null;

    contactsService.loadAll()
        .then(
            response => {
                $scope.contacts = response.data;
            },
            error => {
                alert('Не удалось загрузить контакты');
            });

    $scope.setSelectedContactIndex = (index) => {
        $scope.selectedContactIndex = index;
    }

    $scope.addContact = () => {
        const contact = {
            surname: '',
            name: '',
            patronymic: '',
            phoneNumber: '',
            email: ''
        }

        $scope.contacts.push(contact);
    }

    $scope.removeContact = () => {
        if ($scope.selectedContactIndex === null) {
            return;
        }

        $scope.contacts.splice($scope.selectedContactIndex, 1);
    }

    $scope.saveContacts = () => {
        contactsService.save($scope.contacts);
    }
})