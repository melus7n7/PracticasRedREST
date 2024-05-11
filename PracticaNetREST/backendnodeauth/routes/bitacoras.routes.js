const router = require('express').Router();
const bitacoras = require('../controllers/bitacoras.controller');
const Authorize = require('../middleware/auth.middleware')

router.get('/', Authorize('Administrador'), bitacoras.getAll);

router.get('/:id', Authorize('Administrador'), bitacoras.get);


module.exports = router;