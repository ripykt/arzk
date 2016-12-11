var APPLICATION_ID = '858A1221-A73E-B5D5-FF54-1B835CF15D00',
    SECRET_KEY = 'F5057FC7-611F-8CEB-FFB6-02BF6268C100',
    VERSION = 'v1'; //default application version;


init();

function maintable(args) {
    args = args || {},
    this.data = args.data || "",
    this.destination = args.destination || "",
    this.time = args.time || "";
}

function init() {
    Backendless.initApp(APPLICATION_ID, SECRET_KEY, VERSION);

    if (Backendless.UserService.getCurrentUser() == null) {
        currentUser = null;
    } else {
        currentUser = Backendless.UserService.getCurrentUser();
    }


};