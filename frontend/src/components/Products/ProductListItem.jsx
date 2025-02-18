import { Link } from 'react-router-dom';
import { useDispatch } from 'react-redux';

import classes from './ProductListItem.module.css';
import Button from '../../UI/Button';

import { cartActions } from '../../store/cart';

/* eslint-disable react/prop-types */
export default function ProductListItem({ product }) {
  const dispatch = useDispatch();

  function handleAddToCartButtonClick() {
    dispatch(cartActions.addItem(product));
  }

  return (
    <article className={classes.product}>
      <Link to={`/products/${product.id}`}>
        <img
          src={`http://localhost:6010/images/${product.image}`} // TODO
          alt={product.name}
        />
        <h3>{product.name}</h3>
        <p>{product.description}</p>
      </Link>
      <div>
        <Button
          title="Add to Cart"
          className={classes.button}
          onClick={handleAddToCartButtonClick}
        />
      </div>
    </article>
  );
}
