import{createStore, applyMiddleWare} from 'redux'
import thunk from 'redux-thunk';
import rootReducer from '../reducers';

const configureStore = () => applyMiddleWare(thunk)(createStore)(rootReducer);

export default configureStore;



