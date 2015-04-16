
var titleListingController = function ($scope, library) {    
    // 'library' should be an 'injected' instance of the whole shebang..

    // initialize...
    $scope.data = library;
    $scope.itemCount = library.Items.length;
    $scope.selectedId = -1;
    
    // methods...
    $scope.setSelectedId = function (id) {
        $scope.selectedId = id;

        if ($scope.itemCount < 1)
            return;

        for (var i = 0; i < $scope.itemCount; i++)
            $scope.data.Items[i].isSelected = $scope.selectedId === $scope.data.Items[i].Id;
    };

    $scope.clearSelection = function () {
        $scope.setSelectedId(-1);
    };

    $scope.initializeSelection = function () {
        $scope.setSelectedId ($scope.itemCount < 1 ? -1 : library.Items[0].Id);
    };

    $scope.isCurrentItem = function (testItem){
        return testItem.Id === $scope.selectedId;
    };

    // more init:
    if ($scope.itemCount > 0)
    {
        // extend all library objects with add'l client-side properties...
        for (var i = 0; i < $scope.itemCount; i++)
        {
            $scope.data.Items[i].isSelected = false;
        }

        $scope.initializeSelection();
    }
};

app.controller('TitleListingController', titleListingController);