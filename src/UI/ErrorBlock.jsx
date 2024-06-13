import classes from './ErrorBlock.module.css';

/* eslint-disable react/prop-types */
export default function ErrorBlock({ title, message }) {
  return (
    <article className={classes.errorblock}>
      <h3>{title}</h3>
      <p>{message}</p>
    </article>
  );
}
